# rabbit-and-sqs

## What is this?
A simple project which demonstrates how to send data to both rabbitmq and SQS. 

We use a wrapper for messages. Generally everything is XML encoded. 

The most interestring parts are probably the classes `RabbitMqTransport`, `SqsIncomingTransport` and `SqsOutgoingTransport`. 

SQS handles large messages differently than Rabbit, which - in our setup - does not have a size limit. The SQS transports makes spillover to an S3 bucket. 


