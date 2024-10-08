﻿// See https://aka.ms/new-console-template for more information
using RabbitMQ.Client;
using RabbitMQ.Client.Events;
using RabbitMQ.Consumer;
using System.Text;

static class program
{
    static void Main(string[] args)
    {
        var factory = new ConnectionFactory
        {
            Uri = new Uri("amqp://guest:guest@localhost:5672")
        };
        using var connection = factory.CreateConnection();
        using var channel = connection.CreateModel();
       QueueConsumer.Consume(channel);
        
    }

}
