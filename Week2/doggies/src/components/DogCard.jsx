import { Card } from "antd"
import { Link } from 'react-router-dom';

const { Meta } = Card;

const DogCard = ({dog}) => {

    return (
        <Link to={`/${dog.id}`}>
            <Card
                hoverable
                style={{ width: 200, height: "100%" }}
                cover={<img alt={dog.name} src={dog.imageUrl} />}>
                <Meta title={dog.name}/>
            </Card>
        </Link>
    )
}

export default DogCard