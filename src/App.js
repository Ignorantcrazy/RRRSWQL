import React,{Component} from 'react';
import {Container,Divider} from 'semantic-ui-react';
import NavBar from './components/NavBar';
import Articles from './components/Articles';
import MenuData from './Data/index'

class App extends Component{
  render(){
    return(
      <Container>
        <NavBar menu={MenuData}/>
        <Divider hidden />
        <Articles />
      </Container>
    );
  }
}

export default App;