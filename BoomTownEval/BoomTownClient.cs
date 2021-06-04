using BoomTownEval.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace BoomTownEval
{
    public class BoomTownClient
    {
        public async Task<string> GetJSONData(string url)
        {
            //needs to be validation here
            HttpClient client = new HttpClient();
            var data = await client.GetAsync(url);
            if (data.StatusCode != System.Net.HttpStatusCode.OK)
            {
                return "Data failed to retrieve with error code" + data.StatusCode;
            }
            var jsonData = data.ToString();
            return jsonData;
        }

        public async Task<BoomTownModel> GetBoomTownData(string url)
        {
            HttpClient client = new HttpClient();
            var data = await client.GetAsync(url);
            if (data.StatusCode != System.Net.HttpStatusCode.OK)
            {
                throw new Exception("Data failed to retrieve with error code" + data.StatusCode);

            }
            var jsonData = data.ToString(); 
            BoomTownModel model = JsonConvert.DeserializeObject<BoomTownModel>(jsonData);
            return model;
        }
        public BoomTownModel VerifyBoomTownData(BoomTownModel model)
        {
            if (model.CreatedAt > model.UpdatedAt)
            {
                var repoData = GetRepoData(model.ReposUrl);
                if (model.PublicRepos == repoData.Result.Count)
                    //repoData seems like it should return a list and then we can make this direct comparision
            }
        }


        public async Task<IssueModel> GetModelData(string url)
        {
            HttpClient client = new HttpClient();
            var data = await client.GetAsync(url);
            if (data.StatusCode != System.Net.HttpStatusCode.OK)
            {
                throw new Exception("Data failed to retrieve with error code" + data.StatusCode);

            }
            var jsonData = data.ToString();
            IssueModel model = JsonConvert.DeserializeObject<IssueModel>(jsonData);
            return model;
        }


        public async Task<RepoModel> GetRepoData(string url)
        {
            HttpClient client = new HttpClient();
            var data = await client.GetAsync(url);
            if (data.StatusCode != System.Net.HttpStatusCode.OK)
            {
                throw new Exception("Data failed to retrieve with error code" + data.StatusCode);

            }
            var jsonData = data.ToString();
            RepoModel model = JsonConvert.DeserializeObject<RepoModel>(jsonData);
            return model;
        }


        public async Task<EventModel> GetEventData(string url)
        {
            HttpClient client = new HttpClient();
            var data = await client.GetAsync(url);
            if (data.StatusCode != System.Net.HttpStatusCode.OK)
            {
                throw new Exception("Data failed to retrieve with error code" + data.StatusCode);

            }
            var jsonData = data.ToString();
            EventModel model = JsonConvert.DeserializeObject<EventModel>(jsonData);
            return model;
        }


        public async Task<HookModel> GetHookData(string url)
        {
            HttpClient client = new HttpClient();
            var data = await client.GetAsync(url);
            if (data.StatusCode != System.Net.HttpStatusCode.OK)
            {
                throw new Exception("Data failed to retrieve with error code" + data.StatusCode);

            }
            var jsonData = data.ToString();
            HookModel model = JsonConvert.DeserializeObject<HookModel>(jsonData);
            return model;
        }
        public async Task<IssueModel> GetIssueData(string url)
        {
            HttpClient client = new HttpClient();
            var data = await client.GetAsync(url);
            if (data.StatusCode != System.Net.HttpStatusCode.OK)
            {
                throw new Exception("Data failed to retrieve with error code" + data.StatusCode);

            }
            var jsonData = data.ToString();
            IssueModel model = JsonConvert.DeserializeObject<IssueModel>(jsonData);
            return model;
        }

        public async Task<MemberModel> GetMemberData(string url)
        {
            HttpClient client = new HttpClient();
            var data = await client.GetAsync(url);
            if (data.StatusCode != System.Net.HttpStatusCode.OK)
            {
                throw new Exception("Data failed to retrieve with error code" + data.StatusCode);

            }
            var jsonData = data.ToString();
            MemberModel model = JsonConvert.DeserializeObject<MemberModel>(jsonData);
            return model;
        }

        public async Task<PublicMemberModel> GetPublicMemberData(string url)
        {
            HttpClient client = new HttpClient();
            var data = await client.GetAsync(url);
            if (data.StatusCode != System.Net.HttpStatusCode.OK)
            {
                throw new Exception("Data failed to retrieve with error code" + data.StatusCode);

            }
            var jsonData = data.ToString();
            PublicMemberModel model = JsonConvert.DeserializeObject<PublicMemberModel>(jsonData);
            return model;
        }

        public string GetAllObjectIDs(string url)
        {
            var boomTownData = GetBoomTownData(url);
            var repoData = GetRepoData(boomTownData.Result.ReposUrl);
            var eventData = GetEventData(boomTownData.Result.EventsUrl);
            var hookData = GetHookData(boomTownData.Result.HooksUrl);
            var issueData = GetIssueData(boomTownData.Result.IssuesUrl);
            var memberData = GetMemberData(boomTownData.Result.MembersUrl);
            var publicMemberData = GetPublicMemberData(boomTownData.Result.PublicMembersUrl);

            string results = repoData.Result.Id.ToString() +" "+ eventData.Result.Id.ToString() + " " + memberData.Result.Id.ToString() + " " + publicMemberData.Result.Id.ToString();

        }




    }
}
