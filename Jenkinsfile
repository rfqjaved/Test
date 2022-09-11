pipeline {  
  agent {label 'Node1'}  
  stages {
  
    stage('Building') {
      steps{
        script {
	   'Lens-Demo.sln'
        }
      }
    }
    stage('Testing') {
      steps{
        script {
	   '*\bin\Lens-Demo.sln'
	}
      }
    }	        
  }  
}


