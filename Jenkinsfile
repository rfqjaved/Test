pipeline {  
  agent {label 'Node1'}  
  stages {
  
    stage('Building') {
      steps{
        script {
	   'xbuild Lens_Demo.sln'
	}
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


