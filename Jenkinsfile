pipeline {  
  agent {label 'Node1'}  
  stages {
  
    stage('Building') {
      steps{
	   sh 'msbuild.exe Lens_Demo.sln'

         }
      
    }
    stage('Testing') {
      steps{
        script {
	   'lens_demo.dll'
	}
      }
    }	        
  }  
}


