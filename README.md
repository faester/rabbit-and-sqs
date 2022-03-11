# rabbit-and-sqs

## What is this?
A simple project which demonstrates how to send data to both rabbitmq and SQS. 

We use a wrapper for messages. Generally everything is XML encoded. 

The most interestring parts are probably the classes `RabbitMqTransport`, `SqsIncomingTransport` and `SqsOutgoingTransport`. 

SQS handles large messages differently than Rabbit, which - in our setup - does not have a size limit. The SQS transports makes spillover to an S3 bucket. 

## Prerequisites
Everything runs from the test class. 

You will need a config.json file in the root of this project. 

It should look like 

```
{
  "sqs_queue": "https://sqs.eu-west-1.amazonaws.com/9999999999/TEMP_lineup_example_1",
  "rabbitmq_queue": "",
  "AWS_ACCESS_KEY_ID": "*redacted*",
  "AWS_SECRET_CLIENT_KEY": "*redacted*",
  "s3_bucket": "temp-lineup-spillover"
}

```
