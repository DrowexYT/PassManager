# PassManager

PassManager is a secure and lightweight password manager written in Python. It allows users to safely store and manage their passwords in a local database with encryption.

## Features

- **Secure Password Storage:** All passwords are encrypted to ensure user data remains secure.
- **User-Friendly Interface:** A simple and intuitive console-based interface.
- **Database Management:** Leverages SQLite for reliable and lightweight storage.
- **Password Generation:** Generate strong and secure passwords.
- **Cross-Platform:** Works on any system with Python installed.

## Installation

1. Clone the repository:
   ```bash
   git clone https://github.com/DrowexYT/PassManager.git
   ```
2. Navigate to the project directory:
   ```bash
   cd PassManager
   ```
3. Install the required dependencies:
   ```bash
   pip install -r requirements.txt
   ```

## Usage

1. Run the program:
   ```bash
   python main.py
   ```
2. Follow the on-screen instructions to:
   - Add a new password.
   - View stored passwords.
   - Generate a secure password.
   - Delete an existing password.

## Requirements

- Python 3.6+
- Dependencies listed in `requirements.txt`

## Security

PassManager encrypts passwords before storing them in the database. Always ensure your master password is strong, as it is the key to accessing your stored passwords.

## Contributing

Contributions are welcome! To contribute:

1. Fork the repository.
2. Create a new branch for your feature or bugfix:
   ```bash
   git checkout -b feature-name
   ```
3. Commit your changes and push them:
   ```bash
   git commit -m "Add feature/fix bug"
   git push origin feature-name
   ```
4. Open a pull request.

## License

This project is licensed under the MIT License. See the [LICENSE](LICENSE) file for details.

## Acknowledgments

- Inspired by the need for secure and simple password management.
- Thank you to all contributors and users!
