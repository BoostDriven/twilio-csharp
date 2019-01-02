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
using Twilio.Rest.Preview.AccSecurity.Service;

namespace Twilio.Tests.Rest.Preview.AccSecurity.Service 
{

    [TestFixture]
    public class VerificationTest : TwilioTest 
    {
        [Test]
        public void TestCreateRequest()
        {
            var twilioRestClient = Substitute.For<ITwilioRestClient>();
            var request = new Request(
                HttpMethod.Post,
                Twilio.Rest.Domain.Preview,
                "/Verification/Services/VAXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX/Verifications",
                ""
            );
            request.AddPostParam("To", Serialize("to"));
            request.AddPostParam("Channel", Serialize("channel"));
            twilioRestClient.Request(request).Throws(new ApiException("Server Error, no content"));

            try
            {
                VerificationResource.Create("VAXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX", "to", "channel", client: twilioRestClient);
                Assert.Fail("Expected TwilioException to be thrown for 500");
            }
            catch (ApiException) {}
            twilioRestClient.Received().Request(request);
        }

        [Test]
        public void TestCreateVerificationResponse()
        {
            var twilioRestClient = Substitute.For<ITwilioRestClient>();
            twilioRestClient.AccountSid.Returns("ACXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX");
            twilioRestClient.Request(Arg.Any<Request>())
                            .Returns(new Response(
                                         System.Net.HttpStatusCode.Created,
                                         "{\"sid\": \"VEaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa\",\"service_sid\": \"VAaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa\",\"account_sid\": \"ACaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa\",\"to\": \"+14159373912\",\"channel\": \"sms\",\"status\": \"pending\",\"valid\": null,\"date_created\": \"2015-07-30T20:00:00Z\",\"date_updated\": \"2015-07-30T20:00:00Z\"}"
                                     ));

            var response = VerificationResource.Create("VAXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX", "to", "channel", client: twilioRestClient);
            Assert.NotNull(response);
        }
    }

}