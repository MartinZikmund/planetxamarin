using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel.Syndication;
using System.Web;
using Firehose.Web.Infrastructure;

namespace Firehose.Web.Authors
{
    public class MartinZikmund : IAmACommunityMember
    {
        public string FirstName => "Martin";

        public string LastName => "Zikmund";

        public string StateOrRegion => "Prague, Czech Republic";

        public string EmailAddress => "martinzikmund@sphereline.com";

        public string ShortBioOrTagLine => "is a mobile + cloud solutions developer, Microsoftie, foodie and Insanity & P90X fan";

        public Uri WebSite => new Uri("http://mzikmund.com/", UriKind.Absolute);

        public string TwitterHandle => "MZetko";

        public string GitHubHandle => "MartinZikmund";

        public string GravatarHash => "d1a45c7ba013fbc3e9044ff6461f6acd";

        public GeoPosition Position => new GeoPosition(50.124017, 14.451934);

        public IEnumerable<Uri> FeedUris
        {
            get { yield return new Uri("http://blog.mzikmund.com/feed/?lang=en_us"); }
        }
        
        public bool Filter(SyndicationItem item)
        {
            return item.Categories.Any(c => c.Name.ToLowerInvariant().Contains("xamarin"));
        }        
    }
}