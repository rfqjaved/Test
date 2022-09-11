pipeline {  
  agent {label 'Node1'}  
  stages {
  
    stage('Building') {
      sh label:
	      'Building the project',
        script: '''
	   msbuild.exe Lens_Demo.sln
	   '''
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


