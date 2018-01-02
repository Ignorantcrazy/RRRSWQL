import React,{Component} from 'react';
import {Container,Divider} from 'semantic-ui-react';
import {Route,Switch} from 'react-router-dom';
import NavBar from './components/NavBar';
import Articles from './components/Articles';
import MenuData from './Data/index';
import CreateNewArticale from './components/CreateNewArticale';

class App extends Component{
  render(){
    return(
        <Container>
          <NavBar menu={MenuData}/>
          <Divider hidden />
          <Switch>
            <Route path="/addCircle/createArticale" component={CreateNewArticale} />
            <Route path="/" component={Articles} />
            <Route path="/lookingAround" component={Articles} />
            <Route path="/message" component={Articles} />
          </Switch>
        </Container>
    );
  }
}

export default App;