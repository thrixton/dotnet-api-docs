        Dim feed As New SyndicationFeed("Feed Title", "Feed Description", New Uri("http:'Feed/Alternate/Link"), "FeedID", DateTime.Now)
        feed.Contributors.Add(New SyndicationPerson("jesper@contoso.com", "Jesper Aaberg", "http:'contoso/jesper"))