import React,{Component} from 'react';
import {Link} from 'react-router-dom';
import PropTypes from 'prop-types';
import {Menu} from 'semantic-ui-react';

class MenuLinkItem extends Component{
    render(){
        var linkStr = '/'+this.props.menuItem.name;
        return (
            <Menu.Item name={this.props.menuItem.name} active={this.props.menuItem.active} link='true'>
                <Link to={linkStr}>
                    {this.props.menuItem.text}
                </Link>
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