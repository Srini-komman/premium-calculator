import React from 'react';
import Button from 'react-bootstrap/Button';
import Form from 'react-bootstrap/Form'
import Col from 'react-bootstrap/Col';

export function CustomerForm() {
    const [validated, setValidated] = React.useState(false);
  
    const handleSubmit = (event) => {
      const form = event.currentTarget;
      if (form.checkValidity() === false) {
        event.preventDefault();
        event.stopPropagation();
      }
  
      setValidated(true);
    };
  
    return (
        <Form validated={validated} onSubmit={handleSubmit}>
        <Form.Row>
            <Form.Group as={Col} controlId="formName">
                <Form.Label htmlFor="textName">Name</Form.Label>
                <Form.Control id="textName" placeholder="Please Enter name" required />
                <Form.Control.Feedback type="invalid">
                    Please enter your name.
                </Form.Control.Feedback>
            </Form.Group>

            <Form.Group as={Col} controlId="formAge">
                <Form.Label>Age</Form.Label>
                <Form.Control placeholder="Please Enter age" required />
                <Form.Control.Feedback type="invalid">
                    Please enter your name.
                </Form.Control.Feedback>
            </Form.Group>
        </Form.Row>

        <Form.Group controlId="formDOB">
            <Form.Label>Date of Birth</Form.Label>
            <Form.Control placeholder="Please Enter age" required />
            <Form.Control.Feedback type="invalid">
                Please enter your Date of Birth.
            </Form.Control.Feedback>
        </Form.Group>                                
        <Form.Row>
            <Form.Group as={Col} controlId="formOccupation">
                <Form.Label>Occupation</Form.Label>
                <Form.Control as="select" defaultValue="Choose..." required>
                    <option>Choose...</option>
                    <option>...</option>
                </Form.Control>
                <Form.Control.Feedback type="invalid">
                    Please select your Occupation.
                </Form.Control.Feedback>
            </Form.Group>

            <Form.Group as={Col} controlId="formDeath">
                <Form.Label>Death</Form.Label>
                <Form.Control placeholder="Please Enter Death sum insured" required/>
                <Form.Control.Feedback type="invalid">
                    Please enter Death sum Insured.
                </Form.Control.Feedback>
            </Form.Group>
        </Form.Row>

        <Button variant="primary" type="submit">
            Submit
        </Button>
    </Form>
    );
  }
  
