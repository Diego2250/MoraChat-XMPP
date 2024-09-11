# MoraChat

MoraChat is a messaging application that supports XMPP (Extensible Messaging and Presence Protocol). It allows users to send and receive messages, manage subscriptions, and participate in group chats. You can find the documentation for the XMPP library used in this application [HERE](https://xmppdotnet.org).

## Features

- **Create User**: Easily create your own user account.
- **Instant Messaging**: Send and receive one-on-one chat messages.
- **Group Chats**: Participate and create group chats and receive group invitations.
- **Subscription Management**: Approve or deny contact and group chat requests.
- **Toast Notifications**: Get instant notifications for new messages and group invitations.
- **User-Friendly Interface**: Intuitive UI with dynamic controls like chat cards and notifications.
- **File Transfer**: MoraChat supports file transfer between users by utilizing an external file server. This allows you to easily share files with your contacts. For more details on the file server used in this application, you can find the documentation [here](https://github.com/markalbrand56/XMPP-File-Server).

## Screenshots

- **Login**:
  
  ![image](https://github.com/user-attachments/assets/f17ef1ac-ec17-445e-a24f-0d2781f33122)

- **Chats**:

  ![image](https://github.com/user-attachments/assets/edbefda7-65e4-4bed-bce0-55583225cd78)

- **Direct Messages**

  ![image](https://github.com/user-attachments/assets/03747e86-5239-4218-858b-14762c3ab726)

-  **Aditional Featurtes**

   ![image](https://github.com/user-attachments/assets/79cccbcd-0f67-47fd-8b74-46fb489eb46d)

-  **Profile**

   ![image](https://github.com/user-attachments/assets/58ab871e-b05f-4a68-9833-3356a50865e2)


## Getting Started

### Prerequisites

- .NET Framework 4.x or higher
- Visual Studio 2019 or later
- XmppDotNet library (Follow [THIS](https://xmppdotnet.org/docs/install-from-nuget/) instructions)
- Material Skin library (Follow [THIS](https://www.nuget.org/packages/MaterialSkin.2/) instructions)

### Installation
1. **Download the Setup File**:
   - Navigate to **Releases** in the repository
   - Download the `MoraChatSetUp.msi`
   - Run the installation wizard


### Access Source Code

1. **Clone the repository**:
   ```bash
   git clone https://github.com/Diego2250/MoraChat-XMPP.git
   cd MoraChat-XMPP
   ```

2. **Open the solution in Visual Studio**:
   - Navigate to the MoraChat-XMPP.sln file and open it with Visual Studio.

3. **Restore NuGet packages**:
   - Right-click on the solution in Visual Studio and select "Restore NuGet Packages."

4. **Build the solution**:
   - Build the solution to ensure all dependencies are correctly installed.

5. **Run the application**:
   - Set `Form1` as the startup project and run the application.

### Usage

1. **Login**:
   - Enter your XMPP server credentials to log in. If you don´t have a user, select the `Create Account` option.
   
2. **Sending Messages**:
   - Select a contact and start sending messages.
   
3. **Group Chats**:
   - Accept group chat invitations and join rooms.
   
4. **Manage Subscriptions**:
   - Approve or deny contact requests directly from the notification.

5. **Logout**:
   - Log out of the application and close the session.

### Code Overview

- **Main Form (`Form1`)**: The primary form that handles login and displays the main chat interface.
- **MoraChat**: Handles the main chat functionalities like sending messages and managing conversations.
- **Custom Controls**: Includes user controls like `crlNotification` for notifications and dynamic chat cards.
- **Toast Notifications**: Implemented using the `frmToasMessage` form to display non-intrusive messages.

### Contributing

If you would like to contribute to MoraChat, please follow these steps:

1. **Fork the repository**.
2. **Create a new branch**: `git checkout -b feature-name`
3. **Commit your changes**: `git commit -m 'Add some feature'`
4. **Push to the branch**: `git push origin feature-name`
5. **Create a pull request**.

### Difficulties

- **Limited Documentation for xmppDotNet:** The use of the xmppDotNet library was challenging due to the limited official documentation available. As a result, many of the implementations were done through trial and error on multiple occasions, and were inspired by other XMPP implementations in different programming languages.

- **Learning Curve with C#:** C# is a language that interests me for my professional future, which is why I chose it for this project. However, it was difficult because I am not fully proficient in the language as I am still learning how to use it.

- **Time Constraints:** Time was the biggest challenge I encountered because it was a fairly long project with relatively little time to complete, and it coincided with other large projects from other classes.

- **Handling Subscriptions and Notifications:** The implementation of managing subscription requests and notifications within custom controls in a FlowLayoutPanel presented challenges, such as dynamically removing controls and updating the visual interface without affecting the application's performance.


### Learned Lessons

- **Importance of Thorough Documentation Review:** Working with XmppDotNet Library highlighted the importance of understanding the available documentation and seeking alternative resources when official documentation is lacking. This experience taught me the value of researching community forums, GitHub repositories, and other implementation examples when facing challenges.

- **Patience and Persistence with Trial and Error:** Implementing XMPP functionalities with limited guidance and documentation required a lot of trial and error, reinforcing the lesson that patience and persistence are key when learning new technologies.

- **Time Management Skills:** Balancing this project alongside other academic commitments taught me how crucial effective time management is. Planning and prioritizing tasks helped in managing a heavy workload.

- **Adapting to New Technologies:** Developing a complex project in C#, a language I’m still learning to use, was a significant challenge but also a valuable learning opportunity. It underscored the importance of adaptability and the continuous learning required in software development.


### License

MoraChat is licensed under the MIT License. See the [LICENSE](LICENSE) file for more details.

### Contact

If you have any questions or feedback, feel free to reach out:

- **Email**: Diego0000352@gmail.com
- **GitHub**: [Diego2250](https://github.com/Diego2250)
