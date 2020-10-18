import React, { Component } from 'react';
import './CustomerDetails.css'
import Container from 'react-bootstrap/Container'
import Row from 'react-bootstrap/Row';
import Col from 'react-bootstrap/Col';
import Card from 'react-bootstrap/Card';

import "react-datetime/css/react-datetime.css";

import {CustomerForm} from './CustomerForm';


export class CustomerDetails extends Component {
  
  render() {    

    return (
        <Container className='mt-5'>
            <Row className="justify-content-md-center">
                <Col sm={6}>
                    <Card className="mb-2" style={{ borderRadius: '0.8rem' }}>
                        <Card.Header>Add Customer Details Form</Card.Header>
                        <Card.Body>
                            <CustomerForm></CustomerForm>
                        </Card.Body>
                    </Card>
                </Col>
            </Row>        
        </Container>
    );
  }
}

export default CustomerDetails;
