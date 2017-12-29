import React,{Component} from 'react';
import PropTypes from 'prop-types';
import {Menu,Icon} from 'semantic-ui-react';

class MenuMessageItem extends Component{
    render(){
        return (
            <Menu.Item>
                <Icon name={this.props.menuMessageItem.name} size={this.props.menuMessageItem.size} link='true' />
            </Menu.Item>
        );
    }
}

MenuMessageItem.propTypes = {
    menuMessageItem : PropTypes.shape({
        name : PropTypes.string.isRequired,
        size : PropTypes.string.isRequired
    }).isRequired
};

export default MenuMessageItem;