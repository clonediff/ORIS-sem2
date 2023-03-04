import { Button, Form, Input, Modal } from "antd";
import { useState } from "react";
import { useNavigate } from "react-router-dom";

const FeedbackPage = () => {
    const [isOpen, setIsOpen] = useState(false)
    const navigate = useNavigate()

    const handleOk = () => navigate("/")

    const sendFeedback = (e) => {
        console.log(e)
        console.log(JSON.stringify(e))
        const requestOptions = {
            method: 'POST',
            headers: {
                'Content-Type': 'application/json'
            },
            body: JSON.stringify(e)
        }

        fetch(`https://localhost:7049/mail`, requestOptions)
            .then(response => setIsOpen(true))
    }

    return (
        <>
            <Form name="feedback"
                    initialValues={{remember: true}}
                    layout="vertical"
                    style={{marginInlineStart: '25%'}}
                    wrapperCol={{span: 16}}
                    onFinish={sendFeedback}>
                <Form.Item label="Email:"
                            name="email"
                            rules={[{required: true, message: "Пожалуйста, введите свой email"},
                            {pattern: /^([0-9a-zA-Z]([\+\-_\.][0-9a-zA-Z]+)*)+@(([0-9a-zA-Z][-\w]*[0-9a-zA-Z]*\.)+[a-zA-Z0-9]{2,17})$/, message: "Неправильный формат email"}]}>
                    <Input autoComplete="off" placeholder="Email..."/>
                </Form.Item>
                <Form.Item label="Отзыв:"
                            name="Message"
                            rules={[{required: true, message: "Нельзя отправить пустой отзыв"}]}>
                    <Input.TextArea placeholder="Введите свой отзыв..." autoSize={{minRows: 20, maxRows: 20}}/>
                </Form.Item>
                <Form.Item>
                    <Button type="primary" htmlType="submit" style={{width: '100%'}}>Отправить отзыв</Button>
                </Form.Item>
            </Form>
            <Modal title=""
                    open={isOpen}
                    footer={[
                        <Button type="primary" onClick={handleOk}>Ok</Button>
                    ]}>
                <p>Спасибо за отзыв!</p>
            </Modal>
        </>
    )
}

export default FeedbackPage;