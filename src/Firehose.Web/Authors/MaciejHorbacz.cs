using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel.Syndication;
using System.Web;
using Firehose.Web.Infrastructure;

namespace Firehose.Web.Authors
{
    public class MaciejHorbacz : IAmACommunityMember
    {
        public string FirstName => "Maciej";
        public string LastName => "Horbacz";
        public string ShortBioOrTagLine => "I use Powershell for daily tasks and automation of every process.";
        public string StateOrRegion => "Wroclaw, Poland";
        public string EmailAddress => "maciej.horbacz@gmail.com";
        public string TwitterHandle => "Universecitiz3n";
        public string GitHubHandle => "Universecitiz3n";
        public string GravatarHash => "f59ba35493d7f1b99e25b6455dc39f5b";
        public GeoPosition Position => new GeoPosition(51.1078850,17.0385380);
        public Uri WebSite => new Uri("https://www.universecitiz3n.tech");
        public IEnumerable<Uri> FeedUris { get { yield return new Uri("https://www.universecitiz3n.tech/feed.xml"); } }
        public string FeedLanguageCode => "en";
    }
}
