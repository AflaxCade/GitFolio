using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http.Headers;
using System.Net.Http;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;

namespace GitFolio
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private async void btnFetch_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text.Trim();
            if (string.IsNullOrEmpty(username))
            {
                msgEmpty.Show();
                return;
            }

            if (!System.Net.NetworkInformation.NetworkInterface.GetIsNetworkAvailable())
            {
                msgNet.Show("No internet connection. Please check your network settings.");
                return;
            }

            string apiUrl = $"https://api.github.com/users/{username}";

            using (HttpClient client = new HttpClient())
            {
                client.DefaultRequestHeaders.UserAgent.ParseAdd("Mozilla/5.0 (compatible; GrandCircus/1.0)");
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

                HttpResponseMessage response = await client.GetAsync(apiUrl);

                if (response.IsSuccessStatusCode)
                {
                    string jsonData = await response.Content.ReadAsStringAsync();
                    var userInfo = JsonConvert.DeserializeObject<dynamic>(jsonData);

                    // Access the retrieved information
                    string avatarUrl = userInfo.avatar_url;
                    string userName = userInfo.login;
                    string name = userInfo.name;
                    string bio = userInfo.bio;
                    string company = userInfo.company;
                    int followersCount = userInfo.followers;
                    int followingCount = userInfo.following;
                    string location = userInfo.location;
                    string email = userInfo.email;
                    string twitter = userInfo.twitter_username;
                    string blog = userInfo.blog;
                    string reposCount = userInfo.public_repos;
                    string repositoriesUrl = userInfo.repos_url;
                    string create = userInfo.created_at.ToString();
                    string update = userInfo.updated_at.ToString();

                    // Fetch the repositories
                    HttpResponseMessage repositoriesResponse = await client.GetAsync(repositoriesUrl);
                    if (repositoriesResponse.IsSuccessStatusCode)
                    {
                        string repositoriesData = await repositoriesResponse.Content.ReadAsStringAsync();
                        dynamic repositories = JsonConvert.DeserializeObject(repositoriesData);

                        // Clear the existing items in the ListBox
                        listBoxRepositories.Items.Clear();

                        // Add repository names to the ListBox
                        foreach (var repository in repositories)
                        {
                            string repositoryName = repository.name;
                            listBoxRepositories.Items.Add(repositoryName);

                        }
                    }
                    else if (repositoriesResponse.StatusCode == HttpStatusCode.Forbidden)
                    {
                        msgRepo.Show("API rate limit exceeded. Please try again later or authenticate your requests for a higher rate limit.");
                    }
                    else
                    {
                        msgError.Show("Failed to fetch repositories.");
                    }

                    // Display the output
                    pictureBoxProfilePicture.SizeMode = PictureBoxSizeMode.StretchImage;
                    pictureBoxProfilePicture.ImageLocation = avatarUrl;
                    lblUsername.Text = userName;
                    lbl_bio.Text = !string.IsNullOrEmpty(bio) ? bio : "Null";
                    lblName.Text = !string.IsNullOrEmpty(name) ? $"Name : {name}" : "Name : Null";
                    txtCompany.Text = !string.IsNullOrEmpty(company) ? $"Company : {company}" : "Company : Null";
                    lblFollow.Text = $"{followersCount} Followers. {followingCount} Following";
                    lblLocation.Text = !string.IsNullOrEmpty(location) ? $"Location : {location}" : "Location: Null";
                    lblReposcount.Text = $"Repositories : {reposCount}";
                    lblMail.Text = !string.IsNullOrEmpty(email) ? email : "Null";
                    lblTwitter.Text = !string.IsNullOrEmpty(twitter) ? twitter : "Null";
                    lblBlog.Text = !string.IsNullOrEmpty(blog) ? blog : "Null";
                    lblCreate.Text = $"Created at : {create}";
                    lblUpdate.Text = $"Last updated at : {update}";

                }
                else if (response.StatusCode == HttpStatusCode.Forbidden)
                {
                    msgRepo.Show("API rate limit exceeded. Please try again later or authenticate your requests for a higher rate limit.");
                }
                else
                {
                    msgError.Show("Failed to fetch user information. Please check the username and try again.");
                }
            }
        }
    }
}
