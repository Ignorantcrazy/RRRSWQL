import React,{Component} from 'react';
import {Container} from 'semantic-ui-react';
import NavBar from './components/NavBar';
import Articles from './components/Articles';
import MenuData from './Data/index'

class App extends Component{
  render(){
    return(
      <Container>
        <NavBar menu={MenuData}/>
        <Articles />
      </Container>
    );
  }
}

export default App;