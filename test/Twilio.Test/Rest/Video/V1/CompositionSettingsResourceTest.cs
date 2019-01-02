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
using Twilio.Rest.Video.V1;

namespace Twilio.Tests.Rest.Video.V1 
{

    [TestFixture]
    public class CompositionSettingsTest : TwilioTest 
    {
        [Test]
        public void TestFetchRequest()
        {
            var twilioRestClient = Substitute.For<ITwilioRestClient>();
            var request = new Request(
                HttpMethod.Get,
                Twilio.Rest.Domain.Video,
                "/v1/CompositionSettings/Default",
                ""
            );
            twilioRestClient.Request(request).Throws(new ApiException("Server Error, no content"));

            try
            {
                CompositionSettingsResource.Fetch(client: twilioRestClient);
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
                                         "{\"account_sid\": \"ACaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa\",\"friendly_name\": \"string\",\"aws_credentials_sid\": \"CRaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa\",\"encryption_key_sid\": \"CRaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa\",\"aws_s3_url\": \"https://my-super-duper-bucket.s3.amazonaws.com/my/path/\",\"aws_storage_enabled\": true,\"encryption_enabled\": true,\"url\": \"https://video.twilio.com/v1/CompositionSettings/Default\"}"
                                     ));

            var response = CompositionSettingsResource.Fetch(client: twilioRestClient);
            Assert.NotNull(response);
        }

        [Test]
        public void TestCreateRequest()
        {
            var twilioRestClient = Substitute.For<ITwilioRestClient>();
            var request = new Request(
                HttpMethod.Post,
                Twilio.Rest.Domain.Video,
                "/v1/CompositionSettings/Default",
                ""
            );
            request.AddPostParam("FriendlyName", Serialize("friendlyName"));
            twilioRestClient.Request(request).Throws(new ApiException("Server Error, no content"));

            try
            {
                CompositionSettingsResource.Create("friendlyName", client: twilioRestClient);
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
                                         "{\"account_sid\": \"ACaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa\",\"friendly_name\": \"friendly_name\",\"aws_credentials_sid\": \"CRaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa\",\"encryption_key_sid\": \"CRaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa\",\"aws_s3_url\": \"https://my-super-duper-bucket.s3.amazonaws.com/my/path/\",\"aws_storage_enabled\": true,\"encryption_enabled\": true,\"url\": \"https://video.twilio.com/v1/CompositionSettings/Default\"}"
                                     ));

            var response = CompositionSettingsResource.Create("friendlyName", client: twilioRestClient);
            Assert.NotNull(response);
        }
    }

}