import { useEffect, useState } from "react";
import { useParams } from "react-router-dom"

import { Layout } from "antd"
import DoubleMetricProperty from "../components/DoubleMetricProperty";

const { Sider, Content } = Layout

const DogInfoPage = ({ }) => {
    const {id} = useParams();

    const [dog, setDog] = useState({})
    const [image, setImage] = useState({})

    useEffect(() => {
          const requestOptions = {
            method: 'GET',
            headers: {
              'Content-Type' : 'application/json',
              'x-api-key': 'live_QnPWJXxM820UMS5YwZSNVpteTGnQOBymlEl6q3SVLfEv0VVJw2HGJpPCnCzEoB9W'
            }
          }
              fetch(`https://api.thedogapi.com/v1/images/${id}`, requestOptions)
                .then(response => response.json())
                .then(newData => {
                  setImage(newData)
                  setDog(newData.breeds[0])
                })
          }, [])

    return (
        <Layout style={{height: '100%', padding: 10 }}>
          <Sider width={'35%'} style={{backgroundColor: 'transparent', fontSize: 25}}>
            <img alt={dog.name} src={image.url} width={'100%'} />
            <p style={{textAlign: 'center', fontWeight: 'bold'}}>{dog.name}</p>
          </Sider>
          <Content style={{padding: 15, fontSize: 15}}>
            <DoubleMetricProperty header='Вес:' property={dog.weight}/>
            <DoubleMetricProperty header='Размеры:' property={dog.height}/>
            <h4 style={{display: 'inline'}}>Время жизни:</h4> {dog.life_span}
          </Content>
        </Layout>
    )
}

export default DogInfoPage