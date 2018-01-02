import React,{Component} from 'react';
 //import {Link} from 'react-router-dom';
import {Button} from 'semantic-ui-react';

class AddCirclePopup extends Component{
    constructor(props){
        super(props);
        this.createArticale = this.createArticale.bind(this);
    }
    createArticale(){
        this.props.history.push(this.props.match.path+'/createArticale');
    }
    render(){
        return (
            <Button.Group>
                <Button primary onClick={this.createArticale}>文章</Button>
                <Button.Or />
                <Button secondary>随笔</Button>
            </Button.Group>
        );
    }
}
export default AddCirclePopup;