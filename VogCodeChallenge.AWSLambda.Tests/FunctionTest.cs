using Amazon.DynamoDBv2;
using Amazon.DynamoDBv2.Model;
using Amazon.Lambda.DynamoDBEvents;
using Amazon.Lambda.TestUtilities;
using System;
using System.Collections.Generic;
using Xunit;

namespace VogCodeChallenge.AWSLambda.Tests
{
    public class FunctionTest
    {
        [Fact]
        public void TestFunction()
        {
            DynamoDBEvent evnt = new DynamoDBEvent
            {
                Records = new List<DynamoDBEvent.DynamodbStreamRecord>
                {
                    new DynamoDBEvent.DynamodbStreamRecord
                    {
                        AwsRegion = "us-west-2",
                        Dynamodb = new StreamRecord
                        {
                            ApproximateCreationDateTime = DateTime.Now,
                            Keys = new Dictionary<string, AttributeValue> { {"id", new AttributeValue { S = Guid.NewGuid().ToString() } } },
                            NewImage = new Dictionary<string, AttributeValue> { { "firstname", new AttributeValue { S = "NewValue" } }, { "lastname", new AttributeValue { S = "AnotherNewValue" } } },
                            OldImage = new Dictionary<string, AttributeValue> { { "address", new AttributeValue { S = "OldValue" } }, { "phonenumber", new AttributeValue { S = "AnotherOldValue" } } },
                            StreamViewType = StreamViewType.NEW_AND_OLD_IMAGES
                        }
                    }
                }
            };


            var context = new TestLambdaContext();
            var function = new Function();

            function.FunctionHandler(evnt, context);

            var testLogger = context.Logger as TestLambdaLogger;
			Assert.Contains("Stream processing complete", testLogger.Buffer.ToString());
        }  
    }
}
