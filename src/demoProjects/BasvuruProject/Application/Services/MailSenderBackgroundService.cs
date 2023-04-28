using Core.Application.Pipelines.Logging;
using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using RabbitMQ.Client;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace Application.Services
{
    public interface IMailQueue
    {
        void AddQueue(Order order, OrderItem orderItem);
    }

    public class MailSenderBackgroundService : IHostedService, IDisposable, IMailQueue
    {
        private int executionCount = 0;
        private readonly ILogger<FileLogger> _logger;
        private Timer? _timer = null;
        private static List<Order> _orders = new List<Order>();
        private static List<OrderItem> _ordersi = new List<OrderItem>();
        private readonly IMailService _mailService;
        private static Object locks=new object();

        public MailSenderBackgroundService(ILogger<FileLogger> logger, IMailService mailService)
        {
            _logger = logger;
            _mailService = mailService;
        }

        public Task StartAsync(CancellationToken stoppingToken)
        {
            _logger.LogInformation("Timed Hosted Service running.");

            _timer = new Timer(DoWork, null, TimeSpan.Zero,
                TimeSpan.FromSeconds(5));

            return Task.CompletedTask;
        }

        private void DoWork(object? state)
        {

            lock (locks)
            {


                _logger.LogInformation(
                    "Timed Hosted Service is working. Count: {Count}", _orders.Count);


               

                foreach (var item in _orders)
                { 
                    string product = "\n";
                    decimal price = 0;
                    foreach (var order in _ordersi)
                    {
                        product += order.Product.Name;
                        price += order.Product.UnitPrice;
                        

                    }
                    //TODO
                    var factory = new ConnectionFactory();
                    factory.Uri = new Uri("amqps://yeaixqmp:RmmVEHoOcK-G6tcoj0fuillwq5uyiaF7@cow.rmq2.cloudamqp.com/yeaixqmp");
                    var connection = factory.CreateConnection();

                    var channel = connection.CreateModel();
                    channel.QueueDeclare("mesaj kuyruk", true, false, false);
                    string mesaj = String.Concat("Siparişiniz Alındı Siparişinizdeki ürünler Aşağıda Listelenmiştir", product,"\nsipariş fiyatı:",price,"Bizi Tercih ettiğiniz için teşekkür  ederiz");
                    var message = Encoding.UTF8.GetBytes(mesaj);
                    channel.BasicPublish(String.Empty,"mesaj",null,message);
                    _mailService.SendEmailAsync(new MailRequest() { Body = mesaj, Subject = "Siparişiniz alındı", ToEmail = item.CustomerMail });

                }
                _orders.Clear();
            }
        }

        public Task StopAsync(CancellationToken stoppingToken)
        {
            _logger.LogInformation("Timed Hosted Service is stopping.");

            _timer?.Change(Timeout.Infinite, 0);

            return Task.CompletedTask;
        }

        public void Dispose()
        {
            _timer?.Dispose();
        }

        public void AddQueue(Order order,OrderItem orderItem)
        {
            _orders.Add(order);
            _ordersi.Add(orderItem);
        }
    }
}
