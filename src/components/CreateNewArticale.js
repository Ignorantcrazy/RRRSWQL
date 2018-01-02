import React,{Component} from 'react';
 //import {Link} from 'react-router-dom';
import {Message,Form,Button} from 'semantic-ui-react';

class CreateNewArticale extends Component{
    constructor(props){
        super(props);
        this.state = {
            isError : false
        };
        this.onClickHandle = this.onClickHandle.bind(this);
    }
    onClickHandle(){
        this.setState({isError : true});
    }
    render(){
        var {isError} = this.state;
        return (
            <Form {...this.state.isError ? 'error' : ''}>
                <Form.Input label='Email' placeholder='joe@schmoe.com' />
                <Message
                error
                header='Action Forbidden'
                content='You can only sign up for an account once with a given e-mail address.'
                />
                <Button onClick={this.onClickHandle}>Submit</Button>
            </Form>
        );
    }
}
export default CreateNewArticale;