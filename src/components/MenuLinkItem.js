import React,{Component} from 'react';
import PropTypes from 'prop-types';
import {Menu} from 'semantic-ui-react';

class MenuLinkItem extends Component{
    render(){
        return (
            <Menu.Item name={this.props.menuItem.name} active={this.props.menuItem.active} link='true'>
                {this.props.menuItem.text}
            </Menu.Item>
        );
    }
}

MenuLinkItem.propTypes = {
    menuItem : PropTypes.shape({
        name : PropTypes.string.isRequired,
        active : PropTypes.bool.isRequired,
        text : PropTypes.string.isRequired
    }).isRequired
};

export default MenuLinkItem;