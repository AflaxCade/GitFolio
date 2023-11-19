# GitFolio

Gitfolio is a C# application that retrieves user information and repositories from the GitHub API and displays them in a user-friendly interface.

## Features

- Fetch user information including avatar, username, name, bio, company, followers, following, location, email, Twitter username, blog, repositories count, creation date, and last update date.
- Display the user's profile picture.
- Fetch and display the user's repositories.
- Validates input for empty or null usernames.
- Checks for an active internet connection before making API calls.
- Handles API rate limit exceeded scenarios.

## Prerequisites

- Visual Studio 2022 or later
- .NET Framework 4.7.2 or later
- .NET 7 or later

## Libraries/Frameworks Used
- Guna Framework for UI design
- HttpClient for API requests
- Newtonsoft.Json for JSON parsing

## Getting Started

1. Clone the repository:
```bash
git clone https://github.com/AflaxCade/gitfolio.git
```
2. Open the solution in Visual Studio 2022.
3. Ensure you have the necessary prerequisites installed.
4. Build and run the application.

## Usage
1. Launch the application.
2. Enter a GitHub username in the provided text field.
3. Click the "Search" button to retrieve the user's information and repositories.
4. If the internet connection is not available, an error message will be displayed.
5. If the user exists, their information will be displayed in the UI, including their profile picture, username, name, bio, company, followers count, following count, location, email, Twitter username, blog, repositories count, creation date, and last update date.
6. The user's repositories will be listed in a separate list box.

## Screenshots
Include screenshots or GIFs demonstrating the application's functionality if possible.

## Contributing
If you'd like to contribute to this project, please fork the repository and submit a pull request.

## License
This project is licensed under the MIT License - see the [LICENSE](LICENSE) file for details.
