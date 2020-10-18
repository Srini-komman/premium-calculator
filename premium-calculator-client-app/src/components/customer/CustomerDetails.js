import React, { Component } from 'react';
import Container from 'react-bootstrap/Container'
import Row from 'react-bootstrap/Row'
import Col from 'react-bootstrap/Col'

export class CustomerDetails extends Component {
  
  render() {
    const { values, handleChange } = this.props;
    return (
        <Container>
            <Row className="justify-content-md-center">
                <Col sm={8}>Customer Details</Col>
            </Row>        
        </Container>
    );
  }
}

export default CustomerDetails;
