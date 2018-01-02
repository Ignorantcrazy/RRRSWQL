import React,{Component} from 'react';
import {Link,Route} from 'react-router-dom';
import PropTypes from 'prop-types';
import {Menu,Icon,Popup} from 'semantic-ui-react';
import MessagePopup from './MessagePopup';
import AddCirclePopup from './AddCirclePopup';

class MenuMessageItem extends Component{
    render(){
        const linkStr = this.props.menuMessageItem.link;
        let popup;
        if (linkStr === '/message') {
            popup = <Route path={linkStr} component={MessagePopup} />;
        }
        if (linkStr === '/addCircle') {
            popup = <Route path={linkStr} component={AddCirclePopup} />;
        }
        return (
            <Menu.Item>
                <Popup wide trigger={
                    <Link to={linkStr}>
                        <Icon name={this.props.menuMessageItem.name} size={this.props.menuMessageItem.size} />
                    </Link>} on='click'>
                    {popup}
                </Popup>
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