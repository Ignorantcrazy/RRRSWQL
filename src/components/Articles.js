import React,{Component} from 'react';
import { Segment,Container,Loader } from 'semantic-ui-react';
import Articale from './Articale';

class Articles extends Component{
    constructor(props){
        super(props);
        this.state = {
            error:null,
            isLoaded : false,
            articles : []
        };
    }
    componentDidMount(){
        fetch("http://localhost:8000/api/ql")
            .then(res => res.json())
            .then(
                (result) =>{
                    this.setState({
                        isLoaded:true,
                        articles : result
                    });
            }),
            (error) => {
                this.setState({
                    error:error,
                    isLoaded : true
                });
            }
    }
    render(){
        const {error,isLoaded,articles} = this.state;
        if (error) {
            return <div> Error:{error.message}</div>;
        }else if(!isLoaded){
            return <Loader active inline='centered' content='正在努力...'  />;
        }
        var articale = [];
        articles.forEach(item => {
            articale.push(
                <Segment.Group raised key={item.Id}>
                    <Segment>
                        <Articale articale={item}/>
                    </Segment>
                </Segment.Group>
            );
        });
        // for (let index = 0; index < 10; index++) {
        //     articles.push(
        //         <Segment.Group raised key={index}>
        //             <Segment>
        //                 <Articale />
        //             </Segment>
        //         </Segment.Group>
        //     );
        // }
        return (
            <Container>
                {articale}
            </Container>
        );
    }
}

export default Articles;