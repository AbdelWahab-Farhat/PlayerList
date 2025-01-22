pipeline {
    agent any
    environment {
        PATH = "/bin:/usr/bin:/opt/homebrew/bin:$PATH"
    }
    stages {
        stage('Checkout') {
            steps {
                git 'https://github.com/AbdelWahab-Farhat/PlayerList.git'
                echo "Checkout is Done"
            }
        }
        stage('Restore') {
            steps {
                sh 'dotnet restore'
                echo 'Restore Done'
            }
        }
        stage('Build') {
            steps {
                sh 'dotnet build --configuration Release'
                echo 'Build Done'
            }
        }
        stage('Run') {
            steps {
                sh 'dotnet run --project PlayerList/PlayerList.csproj'
                echo 'Application Running'
            }
        }
    }
    post {
        success {
            echo 'Pipeline completed successfully!'
        }
        failure {
            echo 'Pipeline failed. Check the logs for details.'
        }
    }
}
