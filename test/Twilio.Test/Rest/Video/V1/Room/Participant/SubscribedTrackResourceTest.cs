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
using Twilio.Rest.Video.V1.Room.Participant;

namespace Twilio.Tests.Rest.Video.V1.Room.Participant 
{

    [TestFixture]
    public class SubscribedTrackTest : TwilioTest 
    {
        [Test]
        public void TestFetchRequest()
        {
            var twilioRestClient = Substitute.For<ITwilioRestClient>();
            var request = new Request(
                HttpMethod.Get,
                Twilio.Rest.Domain.Video,
                "/v1/Rooms/RMXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX/Participants/PAXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX/SubscribedTracks/MTXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX",
                ""
            );
            twilioRestClient.Request(request).Throws(new ApiException("Server Error, no content"));

            try
            {
                SubscribedTrackResource.Fetch("RMXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX", "PAXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX", "MTXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX", client: twilioRestClient);
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
                                         "{\"room_sid\": \"RMaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa\",\"date_created\": \"2015-07-30T20:00:00Z\",\"date_updated\": \"2015-07-30T20:00:00Z\",\"participant_sid\": \"PAaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa\",\"publisher_sid\": \"PAbaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa\",\"sid\": \"MTaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa\",\"name\": \"bob-track\",\"kind\": \"data\",\"enabled\": true,\"url\": \"https://video.twilio.com/v1/Rooms/RMaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa/Participants/PAaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa/SubscribedTracks/MTaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa\"}"
                                     ));

            var response = SubscribedTrackResource.Fetch("RMXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX", "PAXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX", "MTXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX", client: twilioRestClient);
            Assert.NotNull(response);
        }

        [Test]
        public void TestReadRequest()
        {
            var twilioRestClient = Substitute.For<ITwilioRestClient>();
            var request = new Request(
                HttpMethod.Get,
                Twilio.Rest.Domain.Video,
                "/v1/Rooms/RMXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX/Participants/PAXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX/SubscribedTracks",
                ""
            );
            twilioRestClient.Request(request).Throws(new ApiException("Server Error, no content"));

            try
            {
                SubscribedTrackResource.Read("RMXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX", "PAXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX", client: twilioRestClient);
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
                                         "{\"subscribed_tracks\": [],\"meta\": {\"page\": 0,\"page_size\": 50,\"first_page_url\": \"https://video.twilio.com/v1/Rooms/RMaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa/Participants/PAaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa/SubscribedTracks?PageSize=50&Page=0\",\"previous_page_url\": null,\"url\": \"https://video.twilio.com/v1/Rooms/RMaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa/Participants/PAaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa/SubscribedTracks?PageSize=50&Page=0\",\"next_page_url\": null,\"key\": \"subscribed_tracks\"}}"
                                     ));

            var response = SubscribedTrackResource.Read("RMXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX", "PAXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX", client: twilioRestClient);
            Assert.NotNull(response);
        }
    }

}