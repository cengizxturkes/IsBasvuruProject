using Core.Application.Pipelines.Logging;
using Domain.Entities;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Services
{
    public interface IMailQueue
    {
        void AddQueue(Order order);
    }

    public class MailSenderBackgroundService : IHostedService, IDisposable, IMailQueue
    {
        private int executionCount = 0;
        private readonly ILogger<FileLogger> _logger;
        private Timer? _timer = null;
        private static List<Order> _orders = new List<Order>();
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
                    _mailService.SendEmailAsync(new MailRequest() { Body = "Sayın müşteri sipariiniz alındı tutarı:" + item.Product.UnitPrice, Subject = "Siparişiniz alındı", ToEmail = item.CustomerMail });
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

        public void AddQueue(Order order)
        {
            _orders.Add(order);
        }
    }
}
