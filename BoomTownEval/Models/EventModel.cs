using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Threading.Tasks;

namespace BoomTownEval.Models
{
    public class EventModel
    {
       
            [JsonProperty("id")]
            public string Id { get; set; }

            [JsonProperty("type")]
            public TemperatureType Type { get; set; }

            [JsonProperty("actor")]
            public Actor Actor { get; set; }

            [JsonProperty("repo")]
            public TemperatureRepo Repo { get; set; }

            [JsonProperty("payload")]
            public Payload Payload { get; set; }

            [JsonProperty("public")]
            public bool Public { get; set; }

            [JsonProperty("created_at")]
            public DateTimeOffset CreatedAt { get; set; }

            [JsonProperty("org")]
            public Actor Org { get; set; }
        }

        public partial class Actor
        {
            [JsonProperty("id")]
            public long Id { get; set; }

            [JsonProperty("login")]
            public Login Login { get; set; }

            [JsonProperty("display_login", NullValueHandling = NullValueHandling.Ignore)]
            public DisplayLogin? DisplayLogin { get; set; }

            [JsonProperty("gravatar_id")]
            public string GravatarId { get; set; }

            [JsonProperty("url")]
            public Uri Url { get; set; }

            [JsonProperty("avatar_url")]
            public Uri AvatarUrl { get; set; }
        }

        public partial class Payload
        {
            [JsonProperty("ref", NullValueHandling = NullValueHandling.Ignore)]
            public string Ref { get; set; }

            [JsonProperty("ref_type", NullValueHandling = NullValueHandling.Ignore)]
            public string RefType { get; set; }

            [JsonProperty("pusher_type", NullValueHandling = NullValueHandling.Ignore)]
            public string PusherType { get; set; }

            [JsonProperty("action", NullValueHandling = NullValueHandling.Ignore)]
            public Action? Action { get; set; }

            [JsonProperty("number", NullValueHandling = NullValueHandling.Ignore)]
            public long? Number { get; set; }

            [JsonProperty("pull_request", NullValueHandling = NullValueHandling.Ignore)]
            public PayloadPullRequest PullRequest { get; set; }

            [JsonProperty("issue", NullValueHandling = NullValueHandling.Ignore)]
            public Issue Issue { get; set; }

            [JsonProperty("comment", NullValueHandling = NullValueHandling.Ignore)]
            public Comment Comment { get; set; }

            [JsonProperty("master_branch", NullValueHandling = NullValueHandling.Ignore)]
            public Branch? MasterBranch { get; set; }

            [JsonProperty("description", NullValueHandling = NullValueHandling.Ignore)]
            public Description? Description { get; set; }

            [JsonProperty("push_id", NullValueHandling = NullValueHandling.Ignore)]
            public long? PushId { get; set; }

            [JsonProperty("size", NullValueHandling = NullValueHandling.Ignore)]
            public long? Size { get; set; }

            [JsonProperty("distinct_size", NullValueHandling = NullValueHandling.Ignore)]
            public long? DistinctSize { get; set; }

            [JsonProperty("head", NullValueHandling = NullValueHandling.Ignore)]
            public string Head { get; set; }

            [JsonProperty("before", NullValueHandling = NullValueHandling.Ignore)]
            public string Before { get; set; }

            [JsonProperty("commits", NullValueHandling = NullValueHandling.Ignore)]
            public Commit[] Commits { get; set; }
        }

        public partial class Comment
        {
            [JsonProperty("url")]
            public Uri Url { get; set; }

            [JsonProperty("html_url")]
            public Uri HtmlUrl { get; set; }

            [JsonProperty("issue_url")]
            public Uri IssueUrl { get; set; }

            [JsonProperty("id")]
            public long Id { get; set; }

            [JsonProperty("node_id")]
            public string NodeId { get; set; }

            [JsonProperty("user")]
            public User User { get; set; }

            [JsonProperty("created_at")]
            public DateTimeOffset CreatedAt { get; set; }

            [JsonProperty("updated_at")]
            public DateTimeOffset UpdatedAt { get; set; }

            [JsonProperty("author_association")]
            public string AuthorAssociation { get; set; }

            [JsonProperty("body")]
            public string Body { get; set; }

            [JsonProperty("performed_via_github_app")]
            public object PerformedViaGithubApp { get; set; }
        }

        public partial class User
        {
            [JsonProperty("login")]
            public Login Login { get; set; }

            [JsonProperty("id")]
            public long Id { get; set; }

            [JsonProperty("node_id")]
            public UserNodeId NodeId { get; set; }

            [JsonProperty("avatar_url")]
            public Uri AvatarUrl { get; set; }

            [JsonProperty("gravatar_id")]
            public string GravatarId { get; set; }

            [JsonProperty("url")]
            public Uri Url { get; set; }

            [JsonProperty("html_url")]
            public Uri HtmlUrl { get; set; }

            [JsonProperty("followers_url")]
            public Uri FollowersUrl { get; set; }

            [JsonProperty("following_url")]
            public string FollowingUrl { get; set; }

            [JsonProperty("gists_url")]
            public GistsUrl GistsUrl { get; set; }

            [JsonProperty("starred_url")]
            public string StarredUrl { get; set; }

            [JsonProperty("subscriptions_url")]
            public Uri SubscriptionsUrl { get; set; }

            [JsonProperty("organizations_url")]
            public Uri OrganizationsUrl { get; set; }

            [JsonProperty("repos_url")]
            public Uri ReposUrl { get; set; }

            [JsonProperty("events_url")]
            public string EventsUrl { get; set; }

            [JsonProperty("received_events_url")]
            public Uri ReceivedEventsUrl { get; set; }

            [JsonProperty("type")]
            public UserType Type { get; set; }

            [JsonProperty("site_admin")]
            public bool SiteAdmin { get; set; }
        }

        public partial class Commit
        {
            [JsonProperty("sha")]
            public string Sha { get; set; }

            [JsonProperty("author")]
            public Author Author { get; set; }

            [JsonProperty("message")]
            public string Message { get; set; }

            [JsonProperty("distinct")]
            public bool Distinct { get; set; }

            [JsonProperty("url")]
            public Uri Url { get; set; }
        }

        public partial class Author
        {
            [JsonProperty("email")]
            public Email Email { get; set; }

            [JsonProperty("name")]
            public AuthorName Name { get; set; }
        }

        public partial class Issue
        {
            [JsonProperty("url")]
            public Uri Url { get; set; }

            [JsonProperty("repository_url")]
            public Uri RepositoryUrl { get; set; }

            [JsonProperty("labels_url")]
            public string LabelsUrl { get; set; }

            [JsonProperty("comments_url")]
            public Uri CommentsUrl { get; set; }

            [JsonProperty("events_url")]
            public Uri EventsUrl { get; set; }

            [JsonProperty("html_url")]
            public Uri HtmlUrl { get; set; }

            [JsonProperty("id")]
            public long Id { get; set; }

            [JsonProperty("node_id")]
            public string NodeId { get; set; }

            [JsonProperty("number")]
            public long Number { get; set; }

            [JsonProperty("title")]
            public string Title { get; set; }

            [JsonProperty("user")]
            public User User { get; set; }

            [JsonProperty("labels")]
            public Label[] Labels { get; set; }

            [JsonProperty("state")]
            public string State { get; set; }

            [JsonProperty("locked")]
            public bool Locked { get; set; }

            [JsonProperty("assignee")]
            public object Assignee { get; set; }

            [JsonProperty("assignees")]
            public object[] Assignees { get; set; }

            [JsonProperty("milestone")]
            public object Milestone { get; set; }

            [JsonProperty("comments")]
            public long Comments { get; set; }

            [JsonProperty("created_at")]
            public DateTimeOffset CreatedAt { get; set; }

            [JsonProperty("updated_at")]
            public DateTimeOffset UpdatedAt { get; set; }

            [JsonProperty("closed_at")]
            public object ClosedAt { get; set; }

            [JsonProperty("author_association")]
            public string AuthorAssociation { get; set; }

            [JsonProperty("active_lock_reason")]
            public object ActiveLockReason { get; set; }

            [JsonProperty("pull_request")]
            public IssuePullRequest PullRequest { get; set; }

            [JsonProperty("body")]
            public string Body { get; set; }

            [JsonProperty("performed_via_github_app")]
            public object PerformedViaGithubApp { get; set; }
        }

        public partial class Label
        {
            [JsonProperty("id")]
            public long Id { get; set; }

            [JsonProperty("node_id")]
            public string NodeId { get; set; }

            [JsonProperty("url")]
            public Uri Url { get; set; }

            [JsonProperty("name")]
            public string Name { get; set; }

            [JsonProperty("color")]
            public string Color { get; set; }

            [JsonProperty("default")]
            public bool Default { get; set; }

            [JsonProperty("description")]
            public string Description { get; set; }
        }

        public partial class IssuePullRequest
        {
            [JsonProperty("url")]
            public Uri Url { get; set; }

            [JsonProperty("html_url")]
            public Uri HtmlUrl { get; set; }

            [JsonProperty("diff_url")]
            public Uri DiffUrl { get; set; }

            [JsonProperty("patch_url")]
            public Uri PatchUrl { get; set; }
        }

        public partial class PayloadPullRequest
        {
            [JsonProperty("url")]
            public Uri Url { get; set; }

            [JsonProperty("id")]
            public long Id { get; set; }

            [JsonProperty("node_id")]
            public string NodeId { get; set; }

            [JsonProperty("html_url")]
            public Uri HtmlUrl { get; set; }

            [JsonProperty("diff_url")]
            public Uri DiffUrl { get; set; }

            [JsonProperty("patch_url")]
            public Uri PatchUrl { get; set; }

            [JsonProperty("issue_url")]
            public Uri IssueUrl { get; set; }

            [JsonProperty("number")]
            public long Number { get; set; }

            [JsonProperty("state")]
            public string State { get; set; }

            [JsonProperty("locked")]
            public bool Locked { get; set; }

            [JsonProperty("title")]
            public string Title { get; set; }

            [JsonProperty("user")]
            public User User { get; set; }

            [JsonProperty("body")]
            public string Body { get; set; }

            [JsonProperty("created_at")]
            public DateTimeOffset CreatedAt { get; set; }

            [JsonProperty("updated_at")]
            public DateTimeOffset UpdatedAt { get; set; }

            [JsonProperty("closed_at")]
            public DateTimeOffset? ClosedAt { get; set; }

            [JsonProperty("merged_at")]
            public DateTimeOffset? MergedAt { get; set; }

            [JsonProperty("merge_commit_sha")]
            public string MergeCommitSha { get; set; }

            [JsonProperty("assignee")]
            public object Assignee { get; set; }

            [JsonProperty("assignees")]
            public object[] Assignees { get; set; }

            [JsonProperty("requested_reviewers")]
            public object[] RequestedReviewers { get; set; }

            [JsonProperty("requested_teams")]
            public object[] RequestedTeams { get; set; }

            [JsonProperty("labels")]
            public Label[] Labels { get; set; }

            [JsonProperty("milestone")]
            public object Milestone { get; set; }

            [JsonProperty("draft")]
            public bool Draft { get; set; }

            [JsonProperty("commits_url")]
            public Uri CommitsUrl { get; set; }

            [JsonProperty("review_comments_url")]
            public Uri ReviewCommentsUrl { get; set; }

            [JsonProperty("review_comment_url")]
            public string ReviewCommentUrl { get; set; }

            [JsonProperty("comments_url")]
            public Uri CommentsUrl { get; set; }

            [JsonProperty("statuses_url")]
            public Uri StatusesUrl { get; set; }

            [JsonProperty("head")]
            public Base Head { get; set; }

            [JsonProperty("base")]
            public Base Base { get; set; }

            [JsonProperty("_links")]
            public Links Links { get; set; }

            [JsonProperty("author_association")]
            public string AuthorAssociation { get; set; }

            [JsonProperty("auto_merge")]
            public object AutoMerge { get; set; }

            [JsonProperty("active_lock_reason")]
            public object ActiveLockReason { get; set; }

            [JsonProperty("merged")]
            public bool Merged { get; set; }

            [JsonProperty("mergeable")]
            public bool? Mergeable { get; set; }

            [JsonProperty("rebaseable")]
            public bool? Rebaseable { get; set; }

            [JsonProperty("mergeable_state")]
            public string MergeableState { get; set; }

            [JsonProperty("merged_by")]
            public User MergedBy { get; set; }

            [JsonProperty("comments")]
            public long Comments { get; set; }

            [JsonProperty("review_comments")]
            public long ReviewComments { get; set; }

            [JsonProperty("maintainer_can_modify")]
            public bool MaintainerCanModify { get; set; }

            [JsonProperty("commits")]
            public long Commits { get; set; }

            [JsonProperty("additions")]
            public long Additions { get; set; }

            [JsonProperty("deletions")]
            public long Deletions { get; set; }

            [JsonProperty("changed_files")]
            public long ChangedFiles { get; set; }
        }

        public partial class Base
        {
            [JsonProperty("label")]
            public string Label { get; set; }

            [JsonProperty("ref")]
            public string Ref { get; set; }

            [JsonProperty("sha")]
            public string Sha { get; set; }

            [JsonProperty("user")]
            public User User { get; set; }

            [JsonProperty("repo")]
            public BaseRepo Repo { get; set; }
        }

        public partial class BaseRepo
        {
            [JsonProperty("id")]
            public long Id { get; set; }

            [JsonProperty("node_id")]
            public RepoNodeId NodeId { get; set; }

            [JsonProperty("name")]
            public PurpleName Name { get; set; }

            [JsonProperty("full_name")]
            public FullNameEnum FullName { get; set; }

            [JsonProperty("private")]
            public bool Private { get; set; }

            [JsonProperty("owner")]
            public User Owner { get; set; }

            [JsonProperty("html_url")]
            public Uri HtmlUrl { get; set; }

            [JsonProperty("description")]
            public Description Description { get; set; }

            [JsonProperty("fork")]
            public bool Fork { get; set; }

            [JsonProperty("url")]
            public Uri Url { get; set; }

            [JsonProperty("forks_url")]
            public Uri ForksUrl { get; set; }

            [JsonProperty("keys_url")]
            public KeysUrl KeysUrl { get; set; }

            [JsonProperty("collaborators_url")]
            public string CollaboratorsUrl { get; set; }

            [JsonProperty("teams_url")]
            public Uri TeamsUrl { get; set; }

            [JsonProperty("hooks_url")]
            public Uri HooksUrl { get; set; }

            [JsonProperty("issue_events_url")]
            public string IssueEventsUrl { get; set; }

            [JsonProperty("events_url")]
            public Uri EventsUrl { get; set; }

            [JsonProperty("assignees_url")]
            public string AssigneesUrl { get; set; }

            [JsonProperty("branches_url")]
            public string BranchesUrl { get; set; }

            [JsonProperty("tags_url")]
            public Uri TagsUrl { get; set; }

            [JsonProperty("blobs_url")]
            public string BlobsUrl { get; set; }

            [JsonProperty("git_tags_url")]
            public string GitTagsUrl { get; set; }

            [JsonProperty("git_refs_url")]
            public string GitRefsUrl { get; set; }

            [JsonProperty("trees_url")]
            public string TreesUrl { get; set; }

            [JsonProperty("statuses_url")]
            public string StatusesUrl { get; set; }

            [JsonProperty("languages_url")]
            public Uri LanguagesUrl { get; set; }

            [JsonProperty("stargazers_url")]
            public Uri StargazersUrl { get; set; }

            [JsonProperty("contributors_url")]
            public Uri ContributorsUrl { get; set; }

            [JsonProperty("subscribers_url")]
            public Uri SubscribersUrl { get; set; }

            [JsonProperty("subscription_url")]
            public Uri SubscriptionUrl { get; set; }

            [JsonProperty("commits_url")]
            public CommitsUrl CommitsUrl { get; set; }

            [JsonProperty("git_commits_url")]
            public string GitCommitsUrl { get; set; }

            [JsonProperty("comments_url")]
            public string CommentsUrl { get; set; }

            [JsonProperty("issue_comment_url")]
            public string IssueCommentUrl { get; set; }

            [JsonProperty("contents_url")]
            public string ContentsUrl { get; set; }

            [JsonProperty("compare_url")]
            public string CompareUrl { get; set; }

            [JsonProperty("merges_url")]
            public Uri MergesUrl { get; set; }

            [JsonProperty("archive_url")]
            public string ArchiveUrl { get; set; }

            [JsonProperty("downloads_url")]
            public Uri DownloadsUrl { get; set; }

            [JsonProperty("issues_url")]
            public string IssuesUrl { get; set; }

            [JsonProperty("pulls_url")]
            public string PullsUrl { get; set; }

            [JsonProperty("milestones_url")]
            public string MilestonesUrl { get; set; }

            [JsonProperty("notifications_url")]
            public string NotificationsUrl { get; set; }

            [JsonProperty("labels_url")]
            public LabelsUrl LabelsUrl { get; set; }

            [JsonProperty("releases_url")]
            public ReleasesUrl ReleasesUrl { get; set; }

            [JsonProperty("deployments_url")]
            public Uri DeploymentsUrl { get; set; }

            [JsonProperty("created_at")]
            public DateTimeOffset CreatedAt { get; set; }

            [JsonProperty("updated_at")]
            public DateTimeOffset UpdatedAt { get; set; }

            [JsonProperty("pushed_at")]
            public DateTimeOffset PushedAt { get; set; }

            [JsonProperty("git_url")]
            public GitUrl GitUrl { get; set; }

            [JsonProperty("ssh_url")]
            public SshUrl SshUrl { get; set; }

            [JsonProperty("clone_url")]
            public Uri CloneUrl { get; set; }

            [JsonProperty("svn_url")]
            public Uri SvnUrl { get; set; }

            [JsonProperty("homepage")]
            public object Homepage { get; set; }

            [JsonProperty("size")]
            public long Size { get; set; }

            [JsonProperty("stargazers_count")]
            public long StargazersCount { get; set; }

            [JsonProperty("watchers_count")]
            public long WatchersCount { get; set; }

            [JsonProperty("language")]
            public Language Language { get; set; }

            [JsonProperty("has_issues")]
            public bool HasIssues { get; set; }

            [JsonProperty("has_projects")]
            public bool HasProjects { get; set; }

            [JsonProperty("has_downloads")]
            public bool HasDownloads { get; set; }

            [JsonProperty("has_wiki")]
            public bool HasWiki { get; set; }

            [JsonProperty("has_pages")]
            public bool HasPages { get; set; }

            [JsonProperty("forks_count")]
            public long ForksCount { get; set; }

            [JsonProperty("mirror_url")]
            public object MirrorUrl { get; set; }

            [JsonProperty("archived")]
            public bool Archived { get; set; }

            [JsonProperty("disabled")]
            public bool Disabled { get; set; }

            [JsonProperty("open_issues_count")]
            public long OpenIssuesCount { get; set; }

            [JsonProperty("license")]
            public License License { get; set; }

            [JsonProperty("forks")]
            public long Forks { get; set; }

            [JsonProperty("open_issues")]
            public long OpenIssues { get; set; }

            [JsonProperty("watchers")]
            public long Watchers { get; set; }

            [JsonProperty("default_branch")]
            public Branch DefaultBranch { get; set; }
        }

        public partial class License
        {
    }

    public partial class Links
        {
            [JsonProperty("self")]
            public Comments Self { get; set; }

            [JsonProperty("html")]
            public Comments Html { get; set; }

            [JsonProperty("issue")]
            public Comments Issue { get; set; }

            [JsonProperty("comments")]
            public Comments Comments { get; set; }

            [JsonProperty("review_comments")]
            public Comments ReviewComments { get; set; }

            [JsonProperty("review_comment")]
            public Comments ReviewComment { get; set; }

            [JsonProperty("commits")]
            public Comments Commits { get; set; }

            [JsonProperty("statuses")]
            public Comments Statuses { get; set; }
        }

        public partial class Comments
        {
            [JsonProperty("href")]
            public string Href { get; set; }
        }

        public partial class TemperatureRepo
        {
            [JsonProperty("id")]
            public long Id { get; set; }

            [JsonProperty("name")]
            public FullNameEnum Name { get; set; }

            [JsonProperty("url")]
            public Uri Url { get; set; }
        }

        public enum DisplayLogin { Dependabot, Frockenstein };

        public enum Login { BoomTownRoi, DependabotBot, Frockenstein };

        public enum Action { Closed, Created, Opened };

        public enum GistsUrl { HttpsApiGithubComUsersBoomTownRoiGistsGistId, HttpsApiGithubComUsersDependabot5Bbot5DGistsGistId, HttpsApiGithubComUsersFrockensteinGistsGistId };

        public enum UserNodeId { MdEyOk9YZ2FuaXphdGlvbjEyMtQwOty, Mdm6Qm90NDk2OTkzMzM, Mdq6VxNlcjEzMty0 };

        public enum UserType { Bot, Organization, User };

        public enum Email { JasonBoomtownroiCom, JfinneyfrockGmailCom, The49699333DependabotBotUsersNoreplyGithubCom };

        public enum AuthorName { DependabotBot, JasonFinneyfrock };

        public enum Description { AgileScrumPointingApp };

        public enum Branch { Master };

        public enum CommitsUrl { HttpsApiGithubComReposBoomTownRoiLetsPointCommitsSha };

        public enum FullNameEnum { BoomTownRoiLetsPoint };

        public enum GitUrl { GitGithubComBoomTownRoiLetsPointGit };

        public enum KeysUrl { HttpsApiGithubComReposBoomTownRoiLetsPointKeysKeyId };

        public enum LabelsUrl { HttpsApiGithubComReposBoomTownRoiLetsPointLabelsName };

        public enum Language { TypeScript };

        public enum Key { Apache20 };

        public enum LicenseName { ApacheLicense20 };

        public enum LicenseNodeId { MDc6TGljZw5ZZti };

        public enum SpdxId { Apache20 };

        public enum PurpleName { LetsPoint };

        public enum RepoNodeId { MdEwOlJlcG9ZaXRvcnkxOdMwMtYxMte };

        public enum ReleasesUrl { HttpsApiGithubComReposBoomTownRoiLetsPointReleasesId };

        public enum SshUrl { GitGithubComBoomTownRoiLetsPointGit };

        public enum TemperatureType { CreateEvent, DeleteEvent, IssueCommentEvent, PullRequestEvent, PushEvent };

        internal static class Converter
        {
            public static readonly JsonSerializerSettings Settings = new JsonSerializerSettings
            {
                MetadataPropertyHandling = MetadataPropertyHandling.Ignore,
                DateParseHandling = DateParseHandling.None,
                Converters =
            {
                DisplayLoginConverter.Singleton,
                LoginConverter.Singleton,
                ActionConverter.Singleton,
                GistsUrlConverter.Singleton,
                UserNodeIdConverter.Singleton,
                UserTypeConverter.Singleton,
                EmailConverter.Singleton,
                AuthorNameConverter.Singleton,
                DescriptionConverter.Singleton,
                BranchConverter.Singleton,
                CommitsUrlConverter.Singleton,
                FullNameEnumConverter.Singleton,
                GitUrlConverter.Singleton,
                KeysUrlConverter.Singleton,
                LabelsUrlConverter.Singleton,
                LanguageConverter.Singleton,
                KeyConverter.Singleton,
                LicenseNameConverter.Singleton,
                LicenseNodeIdConverter.Singleton,
                SpdxIdConverter.Singleton,
                PurpleNameConverter.Singleton,
                RepoNodeIdConverter.Singleton,
                ReleasesUrlConverter.Singleton,
                SshUrlConverter.Singleton,
                TemperatureTypeConverter.Singleton,
                new IsoDateTimeConverter { DateTimeStyles = DateTimeStyles.AssumeUniversal }
            },
            };
        }

        internal class DisplayLoginConverter : JsonConverter
        {
            public override bool CanConvert(Type t) => t == typeof(DisplayLogin) || t == typeof(DisplayLogin?);

            public override object ReadJson(JsonReader reader, Type t, object existingValue, JsonSerializer serializer)
            {
                if (reader.TokenType == JsonToken.Null) return null;
                var value = serializer.Deserialize<string>(reader);
                switch (value)
                {
                    case "dependabot":
                        return DisplayLogin.Dependabot;
                    case "frockenstein":
                        return DisplayLogin.Frockenstein;
                }
                throw new Exception("Cannot unmarshal type DisplayLogin");
            }

            public override void WriteJson(JsonWriter writer, object untypedValue, JsonSerializer serializer)
            {
                if (untypedValue == null)
                {
                    serializer.Serialize(writer, null);
                    return;
                }
                var value = (DisplayLogin)untypedValue;
                switch (value)
                {
                    case DisplayLogin.Dependabot:
                        serializer.Serialize(writer, "dependabot");
                        return;
                    case DisplayLogin.Frockenstein:
                        serializer.Serialize(writer, "frockenstein");
                        return;
                }
                throw new Exception("Cannot marshal type DisplayLogin");
            }

            public static readonly DisplayLoginConverter Singleton = new DisplayLoginConverter();
        }

        internal class LoginConverter : JsonConverter
        {
            public override bool CanConvert(Type t) => t == typeof(Login) || t == typeof(Login?);

            public override object ReadJson(JsonReader reader, Type t, object existingValue, JsonSerializer serializer)
            {
                if (reader.TokenType == JsonToken.Null) return null;
                var value = serializer.Deserialize<string>(reader);
                switch (value)
                {
                    case "BoomTownROI":
                        return Login.BoomTownRoi;
                    case "dependabot[bot]":
                        return Login.DependabotBot;
                    case "frockenstein":
                        return Login.Frockenstein;
                }
                throw new Exception("Cannot unmarshal type Login");
            }

            public override void WriteJson(JsonWriter writer, object untypedValue, JsonSerializer serializer)
            {
                if (untypedValue == null)
                {
                    serializer.Serialize(writer, null);
                    return;
                }
                var value = (Login)untypedValue;
                switch (value)
                {
                    case Login.BoomTownRoi:
                        serializer.Serialize(writer, "BoomTownROI");
                        return;
                    case Login.DependabotBot:
                        serializer.Serialize(writer, "dependabot[bot]");
                        return;
                    case Login.Frockenstein:
                        serializer.Serialize(writer, "frockenstein");
                        return;
                }
                throw new Exception("Cannot marshal type Login");
            }

            public static readonly LoginConverter Singleton = new LoginConverter();
        }

        internal class ActionConverter : JsonConverter
        {
            public override bool CanConvert(Type t) => t == typeof(Action) || t == typeof(Action?);

            public override object ReadJson(JsonReader reader, Type t, object existingValue, JsonSerializer serializer)
            {
                if (reader.TokenType == JsonToken.Null) return null;
                var value = serializer.Deserialize<string>(reader);
                switch (value)
                {
                    case "closed":
                        return Action.Closed;
                    case "created":
                        return Action.Created;
                    case "opened":
                        return Action.Opened;
                }
                throw new Exception("Cannot unmarshal type Action");
            }

            public override void WriteJson(JsonWriter writer, object untypedValue, JsonSerializer serializer)
            {
                if (untypedValue == null)
                {
                    serializer.Serialize(writer, null);
                    return;
                }
                var value = (Action)untypedValue;
                switch (value)
                {
                    case Action.Closed:
                        serializer.Serialize(writer, "closed");
                        return;
                    case Action.Created:
                        serializer.Serialize(writer, "created");
                        return;
                    case Action.Opened:
                        serializer.Serialize(writer, "opened");
                        return;
                }
                throw new Exception("Cannot marshal type Action");
            }

            public static readonly ActionConverter Singleton = new ActionConverter();
        }

        internal class GistsUrlConverter : JsonConverter
        {
            public override bool CanConvert(Type t) => t == typeof(GistsUrl) || t == typeof(GistsUrl?);

            public override object ReadJson(JsonReader reader, Type t, object existingValue, JsonSerializer serializer)
            {
                if (reader.TokenType == JsonToken.Null) return null;
                var value = serializer.Deserialize<string>(reader);
                switch (value)
                {
                    case "https://api.github.com/users/BoomTownROI/gists{/gist_id}":
                        return GistsUrl.HttpsApiGithubComUsersBoomTownRoiGistsGistId;
                    case "https://api.github.com/users/dependabot%5Bbot%5D/gists{/gist_id}":
                        return GistsUrl.HttpsApiGithubComUsersDependabot5Bbot5DGistsGistId;
                    case "https://api.github.com/users/frockenstein/gists{/gist_id}":
                        return GistsUrl.HttpsApiGithubComUsersFrockensteinGistsGistId;
                }
                throw new Exception("Cannot unmarshal type GistsUrl");
            }

            public override void WriteJson(JsonWriter writer, object untypedValue, JsonSerializer serializer)
            {
                if (untypedValue == null)
                {
                    serializer.Serialize(writer, null);
                    return;
                }
                var value = (GistsUrl)untypedValue;
                switch (value)
                {
                    case GistsUrl.HttpsApiGithubComUsersBoomTownRoiGistsGistId:
                        serializer.Serialize(writer, "https://api.github.com/users/BoomTownROI/gists{/gist_id}");
                        return;
                    case GistsUrl.HttpsApiGithubComUsersDependabot5Bbot5DGistsGistId:
                        serializer.Serialize(writer, "https://api.github.com/users/dependabot%5Bbot%5D/gists{/gist_id}");
                        return;
                    case GistsUrl.HttpsApiGithubComUsersFrockensteinGistsGistId:
                        serializer.Serialize(writer, "https://api.github.com/users/frockenstein/gists{/gist_id}");
                        return;
                }
                throw new Exception("Cannot marshal type GistsUrl");
            }

            public static readonly GistsUrlConverter Singleton = new GistsUrlConverter();
        }

        internal class UserNodeIdConverter : JsonConverter
        {
            public override bool CanConvert(Type t) => t == typeof(UserNodeId) || t == typeof(UserNodeId?);

            public override object ReadJson(JsonReader reader, Type t, object existingValue, JsonSerializer serializer)
            {
                if (reader.TokenType == JsonToken.Null) return null;
                var value = serializer.Deserialize<string>(reader);
                switch (value)
                {
                    case "MDEyOk9yZ2FuaXphdGlvbjEyMTQwOTY=":
                        return UserNodeId.MdEyOk9YZ2FuaXphdGlvbjEyMtQwOty;
                    case "MDM6Qm90NDk2OTkzMzM=":
                        return UserNodeId.Mdm6Qm90NDk2OTkzMzM;
                    case "MDQ6VXNlcjEzMTY0":
                        return UserNodeId.Mdq6VxNlcjEzMty0;
                }
                throw new Exception("Cannot unmarshal type UserNodeId");
            }

            public override void WriteJson(JsonWriter writer, object untypedValue, JsonSerializer serializer)
            {
                if (untypedValue == null)
                {
                    serializer.Serialize(writer, null);
                    return;
                }
                var value = (UserNodeId)untypedValue;
                switch (value)
                {
                    case UserNodeId.MdEyOk9YZ2FuaXphdGlvbjEyMtQwOty:
                        serializer.Serialize(writer, "MDEyOk9yZ2FuaXphdGlvbjEyMTQwOTY=");
                        return;
                    case UserNodeId.Mdm6Qm90NDk2OTkzMzM:
                        serializer.Serialize(writer, "MDM6Qm90NDk2OTkzMzM=");
                        return;
                    case UserNodeId.Mdq6VxNlcjEzMty0:
                        serializer.Serialize(writer, "MDQ6VXNlcjEzMTY0");
                        return;
                }
                throw new Exception("Cannot marshal type UserNodeId");
            }

            public static readonly UserNodeIdConverter Singleton = new UserNodeIdConverter();
        }

        internal class UserTypeConverter : JsonConverter
        {
            public override bool CanConvert(Type t) => t == typeof(UserType) || t == typeof(UserType?);

            public override object ReadJson(JsonReader reader, Type t, object existingValue, JsonSerializer serializer)
            {
                if (reader.TokenType == JsonToken.Null) return null;
                var value = serializer.Deserialize<string>(reader);
                switch (value)
                {
                    case "Bot":
                        return UserType.Bot;
                    case "Organization":
                        return UserType.Organization;
                    case "User":
                        return UserType.User;
                }
                throw new Exception("Cannot unmarshal type UserType");
            }

            public override void WriteJson(JsonWriter writer, object untypedValue, JsonSerializer serializer)
            {
                if (untypedValue == null)
                {
                    serializer.Serialize(writer, null);
                    return;
                }
                var value = (UserType)untypedValue;
                switch (value)
                {
                    case UserType.Bot:
                        serializer.Serialize(writer, "Bot");
                        return;
                    case UserType.Organization:
                        serializer.Serialize(writer, "Organization");
                        return;
                    case UserType.User:
                        serializer.Serialize(writer, "User");
                        return;
                }
                throw new Exception("Cannot marshal type UserType");
            }

            public static readonly UserTypeConverter Singleton = new UserTypeConverter();
        }

        internal class EmailConverter : JsonConverter
        {
            public override bool CanConvert(Type t) => t == typeof(Email) || t == typeof(Email?);

            public override object ReadJson(JsonReader reader, Type t, object existingValue, JsonSerializer serializer)
            {
                if (reader.TokenType == JsonToken.Null) return null;
                var value = serializer.Deserialize<string>(reader);
                switch (value)
                {
                    case "49699333+dependabot[bot]@users.noreply.github.com":
                        return Email.The49699333DependabotBotUsersNoreplyGithubCom;
                    case "jason@boomtownroi.com":
                        return Email.JasonBoomtownroiCom;
                    case "jfinneyfrock@gmail.com":
                        return Email.JfinneyfrockGmailCom;
                }
                throw new Exception("Cannot unmarshal type Email");
            }

            public override void WriteJson(JsonWriter writer, object untypedValue, JsonSerializer serializer)
            {
                if (untypedValue == null)
                {
                    serializer.Serialize(writer, null);
                    return;
                }
                var value = (Email)untypedValue;
                switch (value)
                {
                    case Email.The49699333DependabotBotUsersNoreplyGithubCom:
                        serializer.Serialize(writer, "49699333+dependabot[bot]@users.noreply.github.com");
                        return;
                    case Email.JasonBoomtownroiCom:
                        serializer.Serialize(writer, "jason@boomtownroi.com");
                        return;
                    case Email.JfinneyfrockGmailCom:
                        serializer.Serialize(writer, "jfinneyfrock@gmail.com");
                        return;
                }
                throw new Exception("Cannot marshal type Email");
            }

            public static readonly EmailConverter Singleton = new EmailConverter();
        }

        internal class AuthorNameConverter : JsonConverter
        {
            public override bool CanConvert(Type t) => t == typeof(AuthorName) || t == typeof(AuthorName?);

            public override object ReadJson(JsonReader reader, Type t, object existingValue, JsonSerializer serializer)
            {
                if (reader.TokenType == JsonToken.Null) return null;
                var value = serializer.Deserialize<string>(reader);
                switch (value)
                {
                    case "Jason Finneyfrock":
                        return AuthorName.JasonFinneyfrock;
                    case "dependabot[bot]":
                        return AuthorName.DependabotBot;
                }
                throw new Exception("Cannot unmarshal type AuthorName");
            }

            public override void WriteJson(JsonWriter writer, object untypedValue, JsonSerializer serializer)
            {
                if (untypedValue == null)
                {
                    serializer.Serialize(writer, null);
                    return;
                }
                var value = (AuthorName)untypedValue;
                switch (value)
                {
                    case AuthorName.JasonFinneyfrock:
                        serializer.Serialize(writer, "Jason Finneyfrock");
                        return;
                    case AuthorName.DependabotBot:
                        serializer.Serialize(writer, "dependabot[bot]");
                        return;
                }
                throw new Exception("Cannot marshal type AuthorName");
            }

            public static readonly AuthorNameConverter Singleton = new AuthorNameConverter();
        }

        internal class DescriptionConverter : JsonConverter
        {
            public override bool CanConvert(Type t) => t == typeof(Description) || t == typeof(Description?);

            public override object ReadJson(JsonReader reader, Type t, object existingValue, JsonSerializer serializer)
            {
                if (reader.TokenType == JsonToken.Null) return null;
                var value = serializer.Deserialize<string>(reader);
                if (value == "Agile Scrum Pointing App")
                {
                    return Description.AgileScrumPointingApp;
                }
                throw new Exception("Cannot unmarshal type Description");
            }

            public override void WriteJson(JsonWriter writer, object untypedValue, JsonSerializer serializer)
            {
                if (untypedValue == null)
                {
                    serializer.Serialize(writer, null);
                    return;
                }
                var value = (Description)untypedValue;
                if (value == Description.AgileScrumPointingApp)
                {
                    serializer.Serialize(writer, "Agile Scrum Pointing App");
                    return;
                }
                throw new Exception("Cannot marshal type Description");
            }

            public static readonly DescriptionConverter Singleton = new DescriptionConverter();
        }

        internal class BranchConverter : JsonConverter
        {
            public override bool CanConvert(Type t) => t == typeof(Branch) || t == typeof(Branch?);

            public override object ReadJson(JsonReader reader, Type t, object existingValue, JsonSerializer serializer)
            {
                if (reader.TokenType == JsonToken.Null) return null;
                var value = serializer.Deserialize<string>(reader);
                if (value == "master")
                {
                    return Branch.Master;
                }
                throw new Exception("Cannot unmarshal type Branch");
            }

            public override void WriteJson(JsonWriter writer, object untypedValue, JsonSerializer serializer)
            {
                if (untypedValue == null)
                {
                    serializer.Serialize(writer, null);
                    return;
                }
                var value = (Branch)untypedValue;
                if (value == Branch.Master)
                {
                    serializer.Serialize(writer, "master");
                    return;
                }
                throw new Exception("Cannot marshal type Branch");
            }

            public static readonly BranchConverter Singleton = new BranchConverter();
        }

        internal class CommitsUrlConverter : JsonConverter
        {
            public override bool CanConvert(Type t) => t == typeof(CommitsUrl) || t == typeof(CommitsUrl?);

            public override object ReadJson(JsonReader reader, Type t, object existingValue, JsonSerializer serializer)
            {
                if (reader.TokenType == JsonToken.Null) return null;
                var value = serializer.Deserialize<string>(reader);
                if (value == "https://api.github.com/repos/BoomTownROI/LetsPoint/commits{/sha}")
                {
                    return CommitsUrl.HttpsApiGithubComReposBoomTownRoiLetsPointCommitsSha;
                }
                throw new Exception("Cannot unmarshal type CommitsUrl");
            }

            public override void WriteJson(JsonWriter writer, object untypedValue, JsonSerializer serializer)
            {
                if (untypedValue == null)
                {
                    serializer.Serialize(writer, null);
                    return;
                }
                var value = (CommitsUrl)untypedValue;
                if (value == CommitsUrl.HttpsApiGithubComReposBoomTownRoiLetsPointCommitsSha)
                {
                    serializer.Serialize(writer, "https://api.github.com/repos/BoomTownROI/LetsPoint/commits{/sha}");
                    return;
                }
                throw new Exception("Cannot marshal type CommitsUrl");
            }

            public static readonly CommitsUrlConverter Singleton = new CommitsUrlConverter();
        }

        internal class FullNameEnumConverter : JsonConverter
        {
            public override bool CanConvert(Type t) => t == typeof(FullNameEnum) || t == typeof(FullNameEnum?);

            public override object ReadJson(JsonReader reader, Type t, object existingValue, JsonSerializer serializer)
            {
                if (reader.TokenType == JsonToken.Null) return null;
                var value = serializer.Deserialize<string>(reader);
                if (value == "BoomTownROI/LetsPoint")
                {
                    return FullNameEnum.BoomTownRoiLetsPoint;
                }
                throw new Exception("Cannot unmarshal type FullNameEnum");
            }

            public override void WriteJson(JsonWriter writer, object untypedValue, JsonSerializer serializer)
            {
                if (untypedValue == null)
                {
                    serializer.Serialize(writer, null);
                    return;
                }
                var value = (FullNameEnum)untypedValue;
                if (value == FullNameEnum.BoomTownRoiLetsPoint)
                {
                    serializer.Serialize(writer, "BoomTownROI/LetsPoint");
                    return;
                }
                throw new Exception("Cannot marshal type FullNameEnum");
            }

            public static readonly FullNameEnumConverter Singleton = new FullNameEnumConverter();
        }

        internal class GitUrlConverter : JsonConverter
        {
            public override bool CanConvert(Type t) => t == typeof(GitUrl) || t == typeof(GitUrl?);

            public override object ReadJson(JsonReader reader, Type t, object existingValue, JsonSerializer serializer)
            {
                if (reader.TokenType == JsonToken.Null) return null;
                var value = serializer.Deserialize<string>(reader);
                if (value == "git://github.com/BoomTownROI/LetsPoint.git")
                {
                    return GitUrl.GitGithubComBoomTownRoiLetsPointGit;
                }
                throw new Exception("Cannot unmarshal type GitUrl");
            }

            public override void WriteJson(JsonWriter writer, object untypedValue, JsonSerializer serializer)
            {
                if (untypedValue == null)
                {
                    serializer.Serialize(writer, null);
                    return;
                }
                var value = (GitUrl)untypedValue;
                if (value == GitUrl.GitGithubComBoomTownRoiLetsPointGit)
                {
                    serializer.Serialize(writer, "git://github.com/BoomTownROI/LetsPoint.git");
                    return;
                }
                throw new Exception("Cannot marshal type GitUrl");
            }

            public static readonly GitUrlConverter Singleton = new GitUrlConverter();
        }

        internal class KeysUrlConverter : JsonConverter
        {
            public override bool CanConvert(Type t) => t == typeof(KeysUrl) || t == typeof(KeysUrl?);

            public override object ReadJson(JsonReader reader, Type t, object existingValue, JsonSerializer serializer)
            {
                if (reader.TokenType == JsonToken.Null) return null;
                var value = serializer.Deserialize<string>(reader);
                if (value == "https://api.github.com/repos/BoomTownROI/LetsPoint/keys{/key_id}")
                {
                    return KeysUrl.HttpsApiGithubComReposBoomTownRoiLetsPointKeysKeyId;
                }
                throw new Exception("Cannot unmarshal type KeysUrl");
            }

            public override void WriteJson(JsonWriter writer, object untypedValue, JsonSerializer serializer)
            {
                if (untypedValue == null)
                {
                    serializer.Serialize(writer, null);
                    return;
                }
                var value = (KeysUrl)untypedValue;
                if (value == KeysUrl.HttpsApiGithubComReposBoomTownRoiLetsPointKeysKeyId)
                {
                    serializer.Serialize(writer, "https://api.github.com/repos/BoomTownROI/LetsPoint/keys{/key_id}");
                    return;
                }
                throw new Exception("Cannot marshal type KeysUrl");
            }

            public static readonly KeysUrlConverter Singleton = new KeysUrlConverter();
        }

        internal class LabelsUrlConverter : JsonConverter
        {
            public override bool CanConvert(Type t) => t == typeof(LabelsUrl) || t == typeof(LabelsUrl?);

            public override object ReadJson(JsonReader reader, Type t, object existingValue, JsonSerializer serializer)
            {
                if (reader.TokenType == JsonToken.Null) return null;
                var value = serializer.Deserialize<string>(reader);
                if (value == "https://api.github.com/repos/BoomTownROI/LetsPoint/labels{/name}")
                {
                    return LabelsUrl.HttpsApiGithubComReposBoomTownRoiLetsPointLabelsName;
                }
                throw new Exception("Cannot unmarshal type LabelsUrl");
            }

            public override void WriteJson(JsonWriter writer, object untypedValue, JsonSerializer serializer)
            {
                if (untypedValue == null)
                {
                    serializer.Serialize(writer, null);
                    return;
                }
                var value = (LabelsUrl)untypedValue;
                if (value == LabelsUrl.HttpsApiGithubComReposBoomTownRoiLetsPointLabelsName)
                {
                    serializer.Serialize(writer, "https://api.github.com/repos/BoomTownROI/LetsPoint/labels{/name}");
                    return;
                }
                throw new Exception("Cannot marshal type LabelsUrl");
            }

            public static readonly LabelsUrlConverter Singleton = new LabelsUrlConverter();
        }

        internal class LanguageConverter : JsonConverter
        {
            public override bool CanConvert(Type t) => t == typeof(Language) || t == typeof(Language?);

            public override object ReadJson(JsonReader reader, Type t, object existingValue, JsonSerializer serializer)
            {
                if (reader.TokenType == JsonToken.Null) return null;
                var value = serializer.Deserialize<string>(reader);
                if (value == "TypeScript")
                {
                    return Language.TypeScript;
                }
                throw new Exception("Cannot unmarshal type Language");
            }

            public override void WriteJson(JsonWriter writer, object untypedValue, JsonSerializer serializer)
            {
                if (untypedValue == null)
                {
                    serializer.Serialize(writer, null);
                    return;
                }
                var value = (Language)untypedValue;
                if (value == Language.TypeScript)
                {
                    serializer.Serialize(writer, "TypeScript");
                    return;
                }
                throw new Exception("Cannot marshal type Language");
            }

            public static readonly LanguageConverter Singleton = new LanguageConverter();
        }

        internal class KeyConverter : JsonConverter
        {
            public override bool CanConvert(Type t) => t == typeof(Key) || t == typeof(Key?);

            public override object ReadJson(JsonReader reader, Type t, object existingValue, JsonSerializer serializer)
            {
                if (reader.TokenType == JsonToken.Null) return null;
                var value = serializer.Deserialize<string>(reader);
                if (value == "apache-2.0")
                {
                    return Key.Apache20;
                }
                throw new Exception("Cannot unmarshal type Key");
            }

            public override void WriteJson(JsonWriter writer, object untypedValue, JsonSerializer serializer)
            {
                if (untypedValue == null)
                {
                    serializer.Serialize(writer, null);
                    return;
                }
                var value = (Key)untypedValue;
                if (value == Key.Apache20)
                {
                    serializer.Serialize(writer, "apache-2.0");
                    return;
                }
                throw new Exception("Cannot marshal type Key");
            }

            public static readonly KeyConverter Singleton = new KeyConverter();
        }

        internal class LicenseNameConverter : JsonConverter
        {
            public override bool CanConvert(Type t) => t == typeof(LicenseName) || t == typeof(LicenseName?);

            public override object ReadJson(JsonReader reader, Type t, object existingValue, JsonSerializer serializer)
            {
                if (reader.TokenType == JsonToken.Null) return null;
                var value = serializer.Deserialize<string>(reader);
                if (value == "Apache License 2.0")
                {
                    return LicenseName.ApacheLicense20;
                }
                throw new Exception("Cannot unmarshal type LicenseName");
            }

            public override void WriteJson(JsonWriter writer, object untypedValue, JsonSerializer serializer)
            {
                if (untypedValue == null)
                {
                    serializer.Serialize(writer, null);
                    return;
                }
                var value = (LicenseName)untypedValue;
                if (value == LicenseName.ApacheLicense20)
                {
                    serializer.Serialize(writer, "Apache License 2.0");
                    return;
                }
                throw new Exception("Cannot marshal type LicenseName");
            }

            public static readonly LicenseNameConverter Singleton = new LicenseNameConverter();
        }

        internal class LicenseNodeIdConverter : JsonConverter
        {
            public override bool CanConvert(Type t) => t == typeof(LicenseNodeId) || t == typeof(LicenseNodeId?);

            public override object ReadJson(JsonReader reader, Type t, object existingValue, JsonSerializer serializer)
            {
                if (reader.TokenType == JsonToken.Null) return null;
                var value = serializer.Deserialize<string>(reader);
                if (value == "MDc6TGljZW5zZTI=")
                {
                    return LicenseNodeId.MDc6TGljZw5ZZti;
                }
                throw new Exception("Cannot unmarshal type LicenseNodeId");
            }

            public override void WriteJson(JsonWriter writer, object untypedValue, JsonSerializer serializer)
            {
                if (untypedValue == null)
                {
                    serializer.Serialize(writer, null);
                    return;
                }
                var value = (LicenseNodeId)untypedValue;
                if (value == LicenseNodeId.MDc6TGljZw5ZZti)
                {
                    serializer.Serialize(writer, "MDc6TGljZW5zZTI=");
                    return;
                }
                throw new Exception("Cannot marshal type LicenseNodeId");
            }

            public static readonly LicenseNodeIdConverter Singleton = new LicenseNodeIdConverter();
        }

        internal class SpdxIdConverter : JsonConverter
        {
            public override bool CanConvert(Type t) => t == typeof(SpdxId) || t == typeof(SpdxId?);

            public override object ReadJson(JsonReader reader, Type t, object existingValue, JsonSerializer serializer)
            {
                if (reader.TokenType == JsonToken.Null) return null;
                var value = serializer.Deserialize<string>(reader);
                if (value == "Apache-2.0")
                {
                    return SpdxId.Apache20;
                }
                throw new Exception("Cannot unmarshal type SpdxId");
            }

            public override void WriteJson(JsonWriter writer, object untypedValue, JsonSerializer serializer)
            {
                if (untypedValue == null)
                {
                    serializer.Serialize(writer, null);
                    return;
                }
                var value = (SpdxId)untypedValue;
                if (value == SpdxId.Apache20)
                {
                    serializer.Serialize(writer, "Apache-2.0");
                    return;
                }
                throw new Exception("Cannot marshal type SpdxId");
            }

            public static readonly SpdxIdConverter Singleton = new SpdxIdConverter();
        }

        internal class PurpleNameConverter : JsonConverter
        {
            public override bool CanConvert(Type t) => t == typeof(PurpleName) || t == typeof(PurpleName?);

            public override object ReadJson(JsonReader reader, Type t, object existingValue, JsonSerializer serializer)
            {
                if (reader.TokenType == JsonToken.Null) return null;
                var value = serializer.Deserialize<string>(reader);
                if (value == "LetsPoint")
                {
                    return PurpleName.LetsPoint;
                }
                throw new Exception("Cannot unmarshal type PurpleName");
            }

            public override void WriteJson(JsonWriter writer, object untypedValue, JsonSerializer serializer)
            {
                if (untypedValue == null)
                {
                    serializer.Serialize(writer, null);
                    return;
                }
                var value = (PurpleName)untypedValue;
                if (value == PurpleName.LetsPoint)
                {
                    serializer.Serialize(writer, "LetsPoint");
                    return;
                }
                throw new Exception("Cannot marshal type PurpleName");
            }

            public static readonly PurpleNameConverter Singleton = new PurpleNameConverter();
        }

        internal class RepoNodeIdConverter : JsonConverter
        {
            public override bool CanConvert(Type t) => t == typeof(RepoNodeId) || t == typeof(RepoNodeId?);

            public override object ReadJson(JsonReader reader, Type t, object existingValue, JsonSerializer serializer)
            {
                if (reader.TokenType == JsonToken.Null) return null;
                var value = serializer.Deserialize<string>(reader);
                if (value == "MDEwOlJlcG9zaXRvcnkxODMwMTYxMTE=")
                {
                    return RepoNodeId.MdEwOlJlcG9ZaXRvcnkxOdMwMtYxMte;
                }
                throw new Exception("Cannot unmarshal type RepoNodeId");
            }

            public override void WriteJson(JsonWriter writer, object untypedValue, JsonSerializer serializer)
            {
                if (untypedValue == null)
                {
                    serializer.Serialize(writer, null);
                    return;
                }
                var value = (RepoNodeId)untypedValue;
                if (value == RepoNodeId.MdEwOlJlcG9ZaXRvcnkxOdMwMtYxMte)
                {
                    serializer.Serialize(writer, "MDEwOlJlcG9zaXRvcnkxODMwMTYxMTE=");
                    return;
                }
                throw new Exception("Cannot marshal type RepoNodeId");
            }

            public static readonly RepoNodeIdConverter Singleton = new RepoNodeIdConverter();
        }

        internal class ReleasesUrlConverter : JsonConverter
        {
            public override bool CanConvert(Type t) => t == typeof(ReleasesUrl) || t == typeof(ReleasesUrl?);

            public override object ReadJson(JsonReader reader, Type t, object existingValue, JsonSerializer serializer)
            {
                if (reader.TokenType == JsonToken.Null) return null;
                var value = serializer.Deserialize<string>(reader);
                if (value == "https://api.github.com/repos/BoomTownROI/LetsPoint/releases{/id}")
                {
                    return ReleasesUrl.HttpsApiGithubComReposBoomTownRoiLetsPointReleasesId;
                }
                throw new Exception("Cannot unmarshal type ReleasesUrl");
            }

            public override void WriteJson(JsonWriter writer, object untypedValue, JsonSerializer serializer)
            {
                if (untypedValue == null)
                {
                    serializer.Serialize(writer, null);
                    return;
                }
                var value = (ReleasesUrl)untypedValue;
                if (value == ReleasesUrl.HttpsApiGithubComReposBoomTownRoiLetsPointReleasesId)
                {
                    serializer.Serialize(writer, "https://api.github.com/repos/BoomTownROI/LetsPoint/releases{/id}");
                    return;
                }
                throw new Exception("Cannot marshal type ReleasesUrl");
            }

            public static readonly ReleasesUrlConverter Singleton = new ReleasesUrlConverter();
        }

        internal class SshUrlConverter : JsonConverter
        {
            public override bool CanConvert(Type t) => t == typeof(SshUrl) || t == typeof(SshUrl?);

            public override object ReadJson(JsonReader reader, Type t, object existingValue, JsonSerializer serializer)
            {
                if (reader.TokenType == JsonToken.Null) return null;
                var value = serializer.Deserialize<string>(reader);
                if (value == "git@github.com:BoomTownROI/LetsPoint.git")
                {
                    return SshUrl.GitGithubComBoomTownRoiLetsPointGit;
                }
                throw new Exception("Cannot unmarshal type SshUrl");
            }

            public override void WriteJson(JsonWriter writer, object untypedValue, JsonSerializer serializer)
            {
                if (untypedValue == null)
                {
                    serializer.Serialize(writer, null);
                    return;
                }
                var value = (SshUrl)untypedValue;
                if (value == SshUrl.GitGithubComBoomTownRoiLetsPointGit)
                {
                    serializer.Serialize(writer, "git@github.com:BoomTownROI/LetsPoint.git");
                    return;
                }
                throw new Exception("Cannot marshal type SshUrl");
            }

            public static readonly SshUrlConverter Singleton = new SshUrlConverter();
        }

        internal class TemperatureTypeConverter : JsonConverter
        {
            public override bool CanConvert(Type t) => t == typeof(TemperatureType) || t == typeof(TemperatureType?);

            public override object ReadJson(JsonReader reader, Type t, object existingValue, JsonSerializer serializer)
            {
                if (reader.TokenType == JsonToken.Null) return null;
                var value = serializer.Deserialize<string>(reader);
                switch (value)
                {
                    case "CreateEvent":
                        return TemperatureType.CreateEvent;
                    case "DeleteEvent":
                        return TemperatureType.DeleteEvent;
                    case "IssueCommentEvent":
                        return TemperatureType.IssueCommentEvent;
                    case "PullRequestEvent":
                        return TemperatureType.PullRequestEvent;
                    case "PushEvent":
                        return TemperatureType.PushEvent;
                }
                throw new Exception("Cannot unmarshal type TemperatureType");
            }

            public override void WriteJson(JsonWriter writer, object untypedValue, JsonSerializer serializer)
            {
                if (untypedValue == null)
                {
                    serializer.Serialize(writer, null);
                    return;
                }
                var value = (TemperatureType)untypedValue;
                switch (value)
                {
                    case TemperatureType.CreateEvent:
                        serializer.Serialize(writer, "CreateEvent");
                        return;
                    case TemperatureType.DeleteEvent:
                        serializer.Serialize(writer, "DeleteEvent");
                        return;
                    case TemperatureType.IssueCommentEvent:
                        serializer.Serialize(writer, "IssueCommentEvent");
                        return;
                    case TemperatureType.PullRequestEvent:
                        serializer.Serialize(writer, "PullRequestEvent");
                        return;
                    case TemperatureType.PushEvent:
                        serializer.Serialize(writer, "PushEvent");
                        return;
                }
                throw new Exception("Cannot marshal type TemperatureType");
            }

            public static readonly TemperatureTypeConverter Singleton = new TemperatureTypeConverter();
        }
    }

}
}
