namespace VotingSystem.Tests
{
    public class VotingPollTests
    {
        [Fact]
        public void ZeroCounterWhenCreated()
        {
            var poll = new VotingPoll();

            Assert.Empty(poll.Counters);
        }

        public class VotingPoll
        {
            public VotingPoll()
            {
                Counters = Enumerable.Empty<Counter>();
            }
            
            public IEnumerable<Counter> Counters { get; set; }
            public string Title { get; set; } = "";
        }

        public class VotingPollFactoryTest
        {
            private IVotingPollFactory _factory = new VotingPollFactory();
            private VotingPollFactory.Request _request = new VotingPollFactory.Request
            {
                Title = "fakeTitle",
                Description = "fakeDescription",
                Names = new[] { "fakeName1", "fakeName2" },
            };
            
            [Fact]
            public void Create_ThrowsWhenLessThanTwoCounterNames()
            {
                var factory = new VotingPollFactory();

                _request.Names = new string[] { "fakeName" };
                Assert.Throws<ArgumentException>(() => factory.Create(_request));
                _request.Names = new string[] { };
                Assert.Throws<ArgumentException>(() => factory.Create(_request));
            }

            [Fact]
            public void Create_ReturnsCounterForEachProvidedName()
            {
                _request.Names = new[] { "fakeName1", "fakeName2" };

                var poll = _factory.Create(_request);

                foreach(var name in _request.Names)
                {
                    Assert.Contains(name, poll.Counters.Select(counter => counter.Name));
                }
            }

            [Fact]
            public void Create_AddTitleToThePoll()
            {
                var names = new[] { "fakeName1", "fakeName2" };
                var factory = new VotingPollFactory();
                var fakeTitle = "fakeTitle";
                var poll = factory.Create(_request);

                Assert.Equal(fakeTitle, poll.Title);
            }
        }

        public interface IVotingPollFactory
        {
            VotingPoll Create(VotingPollFactory.Request request);
        }

        public class VotingPollFactory : IVotingPollFactory
        {
            public class Request
            {
                public string Description { get; set; } = "";
                public string Title { get; set; } = "";
                public string[] Names { get; set; } = new string[] { };
            }
            
            public VotingPoll Create(Request request)
            {
                if (request.Names.Length < 2) throw new ArgumentException();

                return new VotingPoll
                {
                    Title = request.Title,
                    Counters = request.Names.Select(name => new Counter(name, 0))
                };
            }
        }

        public interface IVotingPollPersistance
        {

        }
    }
}