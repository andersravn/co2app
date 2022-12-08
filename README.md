# Devlog

## Entry 1

The first part of the idea was to learn some C# and .NET, by building an API, using an interesting data set. I found this dataset that lists CO2 emissions from 500 different foods, available in Denmark. It involved seeding a database, in this case SQLite, using Entity Framework Core. Having tried building test apps with APIs in other languages and frameworks, this felt really nice and simple.

The second part, would be to show the data in an interesting way in a frontend web app. I didn't have a clear idea, but you should be able to search foods and compare their emissions with similar foods. This might require some simple graphs, but also adds additional features to the API, such as defining "similar" foods and the ability to search.

## Entry 2

I thought that a "classic" todo list, a shopping list to be more specific, might be more interesting, because it lets you build up some data over time, so you can compare previous weeks' shopping and CO2 emissions - to see if you get better. As I write this, I realize that this might not be nice, if you realize that you can't really do better, and it becomes clear that you have quite a high footprint.

It would probably be necessary to use some point system, so each "costs" points, as it is difficult to know how much of each item is being bought. This might make it a bit more fun, as it is less shameful to just have a total of points for your week of shopping. You're not told how bad it is, just whether you're doing better or worse week after week.
