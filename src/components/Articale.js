import React,{Component} from 'react';
import {Button,Icon,Item,Label} from 'semantic-ui-react';

class Articale extends Component{
    render(){
        return (
            <Item.Group divided>
                <Item>
                    <Item.Image src='/assets/images/wireframe/image.png' />
                    <Item.Content>
                        <Item.Header as='a'>{this.props.articale.Title}</Item.Header>
                        <Item.Meta>
                        <span className='cinema'>IFC Cinema</span>
                        </Item.Meta>
                        <Item.Description>
                            {this.props.articale.Content}
                        </Item.Description>
                        <Item.Extra>
                        <Button primary floated='right'>
                            Buy tickets
                            <Icon name='right chevron' />
                        </Button>
                        <Label icon='globe' content='Additional Languages' />
                        </Item.Extra>
                    </Item.Content>
                </Item>
            </Item.Group>
        );
    }
}

export default Articale;