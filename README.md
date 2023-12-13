# VPtestProject

Hi, here is my initial solution to the proposed problem in the tech test for Victorian Plumbing.

I created an endpoint using the mediator pattern as it's a pattern I'm familiar with and feel would be useful for these sorts of business logic.

I put some blocks in place for what would be an EF db context, just to showcase some automapped properties. However, this was commented out because the solution itself wouldn't work without an actual DB. However, I've shown how this would work with commented-out methods. Those would just need commenting out and a real DB allocated to the context.

I mapped a few fields manually, for example, the date created, which I'd think the backend would handle if we want more precise times.

I also set up a unit test that would run against the endpoint and show the order response being brought back with up-to-date data.
