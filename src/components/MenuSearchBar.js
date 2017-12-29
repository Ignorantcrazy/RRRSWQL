import React,{Component} from 'react';
import {Menu,Input} from 'semantic-ui-react';

class MenuSearchBar extends Component{
    render(){
        return (
            <Menu.Item>
                <Input transparent icon={{ name: 'search', link: true }} placeholder='Search ...' />
            </Menu.Item>
        );
    }
}

export default MenuSearchBar;