import React,{Component} from 'react';
import {Menu,Image} from 'semantic-ui-react';
import PropTypes from 'prop-types';
import Elliot from '../Image/elliot.jpg'

class MenuSearchBar extends Component{
    render(){
        var src = Elliot;
        // if (this.props.menuUser.src == Images.elliot) {
        //     src  = Images.elliot;
        // }
        return (
            <Menu.Item>
                <Image size='mini' src={src}/>
            </Menu.Item>
        );
    }
}

MenuSearchBar.propTypes = {
    menuUser : PropTypes.shape({
            src : PropTypes.string.isRequired
        }).isRequired
};

export default MenuSearchBar;