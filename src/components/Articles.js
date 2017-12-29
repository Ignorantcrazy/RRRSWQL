import React,{Component} from 'react';
import { Segment,Container } from 'semantic-ui-react';
import Articale from './Articale';

class Articles extends Component{
    render(){
        var articles = [];
        for (let index = 0; index < 10; index++) {
            articles.push(
                <Segment.Group raised key={index}>
                    <Segment>
                        <Articale />
                    </Segment>
                </Segment.Group>
            );
        }
        return (
            <Container>
                {articles}
            </Container>
        );
    }
}

export default Articles;