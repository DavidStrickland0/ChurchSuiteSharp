ChurchSuite.Sharp
================

.Net Standard SDK for accessing the Church Suite Api

Current Services
- Calendar Service

Read only service that gets the current Calander Data

- Small group Service

Read only service that retrieves the list of existing small groups


## How to use - Pretty Basic

            -var httpClient = new HttpClient();-
            -var result = await SmallGroupService.RetrieveSmallGroups('myChurchAccountName, httpClient);-

>Originally hoped to implement the entire Church Suite Api
>However I do not have access to a development instance of Church Suite and do not want to test and work with live production data.
>If theres a specific endpoint you need let me know and Ill try to get it added or of course feel free to add it yourself and put up a PR.
