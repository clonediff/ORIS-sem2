import { Card } from "antd"
import { Link } from 'react-router-dom';

const { Meta } = Card;

const DogCard = ({dog}) => {

    return (
        <Link to={`/${dog.image.id}`}>
            <Card
                hoverable
                style={{ width: 200, height: "100%" }}
                cover={<img alt={dog.name} src={dog.image.url} />}>
                <Meta title={dog.name}/>
            </Card>
        </Link>
    )
}

export default DogCard