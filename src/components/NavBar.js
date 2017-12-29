import React,{Component} from 'react';
import PropTypes from 'prop-types';
import {Menu,Visibility} from 'semantic-ui-react';
import MenuLinkItem from './MenuLinkItem';
import MenuMessageItem from './MenuMessageItem';
import MenuSearchBar from './MenuSearchBar';
import MenuUser from './MenuUser';

class NavBar extends Component{
    constructor(props){
        super(props);
        this.state = {
            menuFixed : false
        };
        this.stickTopMenu = this.stickTopMenu.bind(this);
        this.unStickTopMenu = this.unStickTopMenu.bind(this);
    }
    stickTopMenu(){
        this.setState({menuFixed : true});
    }
    unStickTopMenu(){
        this.setState({menuFixed : false});
    }
    render(){
        var menuLinks = [];
        this.props.menu.menuLinks.forEach(item => {
            menuLinks.push(<MenuLinkItem menuItem={item} key={item.name} />);
        });
        var menuMessages = [];
        this.props.menu.menuMessages.forEach(item => {
            menuMessages.push(<MenuMessageItem menuMessageItem={item} key={item.name} />);
        });
        const {menuFixed} = this.state;
        return (
            <Visibility
            onBottomPassed={this.stickTopMenu}
            onBottomVisible={this.unStickTopMenu}
            once={false}
            >
                <Menu pointing size='large' stackable fixed={menuFixed && 'top'}>
                    {menuLinks}
                    <Menu.Menu position='right'>
                        <MenuSearchBar />
                        {menuMessages}
                        <MenuUser menuUser={this.props.menu.menuUser} />
                    </Menu.Menu>
                </Menu>
            </Visibility>
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