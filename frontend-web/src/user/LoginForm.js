import React, { Component } from 'react';

export default class LoginForm extends Component {
    constructor(props){
        super(props);
        this.state = {
            email: '',
            password: ''
        };
    }

    handleChange = (event) => {
        const value = event.target.value;
        const property = event.target.id;

        this.setState({
            ...this.state,
            [property]: value
        });
    }

    handleSubmit = (event) => {
        console.log(`login form submitted. Email: ${this.state.email}, password: ${this.state.password}`);
        event.preventDefault();
    }

    render(){
        return (
            <form onSubmit={this.handleSubmit}>
                <label>
                    Email: <input id='email' type="text" value={this.state.email} onChange={this.handleChange} />
                </label>
                <label>
                    Password: <input id='password' type="password" value={this.state.password} onChange={this.handleChange}/>
                </label>
                <input type="submit" value="Submit" />
            </form>
        );
    }
}