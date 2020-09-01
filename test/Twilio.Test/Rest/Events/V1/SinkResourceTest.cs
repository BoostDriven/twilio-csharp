/// This code was generated by
/// \ / _    _  _|   _  _
///  | (_)\/(_)(_|\/| |(/_  v1.0.0
///       /       /

using NSubstitute;
using NSubstitute.ExceptionExtensions;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using Twilio.Clients;
using Twilio.Converters;
using Twilio.Exceptions;
using Twilio.Http;
using Twilio.Rest.Events.V1;

namespace Twilio.Tests.Rest.Events.V1
{

    [TestFixture]
    public class SinkTest : TwilioTest
    {
        [Test]
        public void TestFetchRequest()
        {
            var twilioRestClient = Substitute.For<ITwilioRestClient>();
            var request = new Request(
                HttpMethod.Get,
                Twilio.Rest.Domain.Events,
                "/v1/Sinks/DGXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX",
                ""
            );
            twilioRestClient.Request(request).Throws(new ApiException("Server Error, no content"));

            try
            {
                SinkResource.Fetch("DGXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX", client: twilioRestClient);
                Assert.Fail("Expected TwilioException to be thrown for 500");
            }
            catch (ApiException) {}
            twilioRestClient.Received().Request(request);
        }

        [Test]
        public void TestFetchResponse()
        {
            var twilioRestClient = Substitute.For<ITwilioRestClient>();
            twilioRestClient.AccountSid.Returns("ACXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX");
            twilioRestClient.Request(Arg.Any<Request>())
                            .Returns(new Response(
                                         System.Net.HttpStatusCode.OK,
                                         "{\"status\": \"initialized\",\"sink_configuration\": {},\"description\": \"description\",\"sid\": \"DGaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa\",\"date_created\": \"2015-07-30T20:00:00Z\",\"sink_type\": \"kinesis\",\"date_updated\": \"2015-07-30T20:00:00Z\",\"url\": \"https://events.twilio.com/v1/Sinks/DGaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa\",\"links\": {\"sink_test\": \"https://events.twilio.com/v1/Sinks/DGaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa/Test\",\"sink_validate\": \"https://events.twilio.com/v1/Sinks/DGaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa/Validate\"}}"
                                     ));

            var response = SinkResource.Fetch("DGXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX", client: twilioRestClient);
            Assert.NotNull(response);
        }

        [Test]
        public void TestCreateRequest()
        {
            var twilioRestClient = Substitute.For<ITwilioRestClient>();
            var request = new Request(
                HttpMethod.Post,
                Twilio.Rest.Domain.Events,
                "/v1/Sinks",
                ""
            );
            request.AddPostParam("Description", Serialize("description"));
            request.AddPostParam("SinkConfiguration", Serialize("{}"));
            request.AddPostParam("SinkType", Serialize(SinkResource.SinkTypeEnum.Kinesis));
            twilioRestClient.Request(request).Throws(new ApiException("Server Error, no content"));

            try
            {
                SinkResource.Create("description", "{}", SinkResource.SinkTypeEnum.Kinesis, client: twilioRestClient);
                Assert.Fail("Expected TwilioException to be thrown for 500");
            }
            catch (ApiException) {}
            twilioRestClient.Received().Request(request);
        }

        [Test]
        public void TestCreateResponse()
        {
            var twilioRestClient = Substitute.For<ITwilioRestClient>();
            twilioRestClient.AccountSid.Returns("ACXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX");
            twilioRestClient.Request(Arg.Any<Request>())
                            .Returns(new Response(
                                         System.Net.HttpStatusCode.Created,
                                         "{\"status\": \"initialized\",\"sink_configuration\": {\"arn\": \"4242\",\"role_arn\": \"abc123\",\"external_id\": \"010101\"},\"description\": \"description\",\"sid\": \"DGaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa\",\"date_created\": \"2015-07-30T20:00:00Z\",\"sink_type\": \"kinesis\",\"date_updated\": \"2015-07-30T20:00:00Z\",\"url\": \"https://events.twilio.com/v1/Sinks/DGaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa\",\"links\": {\"sink_test\": \"https://events.twilio.com/v1/Sinks/DGaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa/Test\",\"sink_validate\": \"https://events.twilio.com/v1/Sinks/DGaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa/Validate\"}}"
                                     ));

            var response = SinkResource.Create("description", "{}", SinkResource.SinkTypeEnum.Kinesis, client: twilioRestClient);
            Assert.NotNull(response);
        }

        [Test]
        public void TestDeleteRequest()
        {
            var twilioRestClient = Substitute.For<ITwilioRestClient>();
            var request = new Request(
                HttpMethod.Delete,
                Twilio.Rest.Domain.Events,
                "/v1/Sinks/DGXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX",
                ""
            );
            twilioRestClient.Request(request).Throws(new ApiException("Server Error, no content"));

            try
            {
                SinkResource.Delete("DGXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX", client: twilioRestClient);
                Assert.Fail("Expected TwilioException to be thrown for 500");
            }
            catch (ApiException) {}
            twilioRestClient.Received().Request(request);
        }

        [Test]
        public void TestDeleteResponse()
        {
            var twilioRestClient = Substitute.For<ITwilioRestClient>();
            twilioRestClient.AccountSid.Returns("ACXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX");
            twilioRestClient.Request(Arg.Any<Request>())
                            .Returns(new Response(
                                         System.Net.HttpStatusCode.NoContent,
                                         "null"
                                     ));

            var response = SinkResource.Delete("DGXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX", client: twilioRestClient);
            Assert.NotNull(response);
        }

        [Test]
        public void TestReadRequest()
        {
            var twilioRestClient = Substitute.For<ITwilioRestClient>();
            var request = new Request(
                HttpMethod.Get,
                Twilio.Rest.Domain.Events,
                "/v1/Sinks",
                ""
            );
            twilioRestClient.Request(request).Throws(new ApiException("Server Error, no content"));

            try
            {
                SinkResource.Read(client: twilioRestClient);
                Assert.Fail("Expected TwilioException to be thrown for 500");
            }
            catch (ApiException) {}
            twilioRestClient.Received().Request(request);
        }

        [Test]
        public void TestReadEmptyResponse()
        {
            var twilioRestClient = Substitute.For<ITwilioRestClient>();
            twilioRestClient.AccountSid.Returns("ACXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX");
            twilioRestClient.Request(Arg.Any<Request>())
                            .Returns(new Response(
                                         System.Net.HttpStatusCode.OK,
                                         "{\"sinks\": [],\"meta\": {\"page\": 0,\"page_size\": 10,\"first_page_url\": \"https://events.twilio.com/v1/Sinks?PageSize=10&Page=0\",\"previous_page_url\": null,\"url\": \"https://events.twilio.com/v1/Sinks?PageSize=10&Page=0\",\"next_page_url\": null,\"key\": \"sinks\"}}"
                                     ));

            var response = SinkResource.Read(client: twilioRestClient);
            Assert.NotNull(response);
        }

        [Test]
        public void TestReadResultsResponse()
        {
            var twilioRestClient = Substitute.For<ITwilioRestClient>();
            twilioRestClient.AccountSid.Returns("ACXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX");
            twilioRestClient.Request(Arg.Any<Request>())
                            .Returns(new Response(
                                         System.Net.HttpStatusCode.OK,
                                         "{\"sinks\": [{\"status\": \"initialized\",\"sink_configuration\": {},\"description\": \"A Sink\",\"sid\": \"DGaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa\",\"date_created\": \"2015-07-30T20:00:00Z\",\"sink_type\": \"kinesis\",\"date_updated\": \"2015-07-30T20:00:00Z\",\"url\": \"https://events.twilio.com/v1/Sinks/DGaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa\",\"links\": {\"sink_test\": \"https://events.twilio.com/v1/Sinks/DGaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa/Test\",\"sink_validate\": \"https://events.twilio.com/v1/Sinks/DGaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa/Validate\"}},{\"status\": \"initialized\",\"sink_configuration\": {},\"description\": \"ANOTHER Sink\",\"sid\": \"DGaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaab\",\"date_created\": \"2015-07-30T20:00:00Z\",\"sink_type\": \"kinesis\",\"date_updated\": \"2015-07-30T20:00:00Z\",\"url\": \"https://events.twilio.com/v1/Sinks/DGaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaab\",\"links\": {\"sink_test\": \"https://events.twilio.com/v1/Sinks/DGaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaab/Test\",\"sink_validate\": \"https://events.twilio.com/v1/Sinks/DGaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaab/Validate\"}}],\"meta\": {\"page\": 0,\"page_size\": 50,\"first_page_url\": \"https://events.twilio.com/v1/Sinks?PageSize=50&Page=0\",\"previous_page_url\": null,\"url\": \"https://events.twilio.com/v1/Sinks?PageSize=50&Page=0\",\"next_page_url\": null,\"key\": \"sinks\"}}"
                                     ));

            var response = SinkResource.Read(client: twilioRestClient);
            Assert.NotNull(response);
        }
    }

}