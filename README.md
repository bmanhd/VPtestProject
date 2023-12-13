# VPtestProject

Hi Here is my initial solution to the proprosed problem in the tech test for victorian plumbing.

I created an endpoint using the mediator pattern as its a pattern Im familiar with and feel would be useful for these sorts of business logic.

I put some blocks in place for what would be an EF db context, just to showcase some automapped proprties. This however was commented out just because the solution itself wouldnt work without an actual DB. However ive shown how this would work with commented out methods, those would just need commenting out and a real db allocated to the Context.

mapped a few fields manually for example the date created which Id think the BE would handle if we want more precise times.

I also set up a unit test that just would run against the endpoint and show the order response being brought back with up to date data.
