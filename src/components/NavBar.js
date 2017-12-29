import React,{Component} from 'react';
import PropTypes from 'prop-types';
import {Menu} from 'semantic-ui-react';
import MenuLinkItem from './MenuLinkItem';
import MenuMessageItem from './MenuMessageItem';
import MenuSearchBar from './MenuSearchBar';
import MenuUser from './MenuUser';

class NavBar extends Component{
    
    render(){
        var menuLinks = [];
        this.props.menu.menuLinks.forEach(item => {
            menuLinks.push(<MenuLinkItem menuItem={item} key={item.name} />);
        });
        var menuMessages = [];
        this.props.menu.menuMessages.forEach(item => {
            menuMessages.push(<MenuMessageItem menuMessageItem={item} key={item.name} />);
        });
        return (
            <Menu pointing size='large' stackable>
                {menuLinks}
                <Menu.Menu position='right'>
                    <MenuSearchBar />
                    {menuMessages}
                    <MenuUser menuUser={this.props.menu.menuUser} />
                </Menu.Menu>
            </Menu>
        );
    }
}

NavBar.propTypes ={
    menu : PropTypes.shape({
            menuLinks : PropTypes.array.isRequired,
            menuMessages : PropTypes.array.isRequired,
            menuUser : PropTypes.object.isRequired
        }).isRequired
};

export default NavBar;