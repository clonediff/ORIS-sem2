import { useEffect, useState } from "react";
import { useParams } from "react-router-dom"

import { Layout } from "antd"
import DoubleMetricProperty from "../components/DoubleMetricProperty";
import Interval from "../components/Interval";

const { Sider, Content } = Layout

const DogInfoPage = ({ }) => {
    const {id} = useParams();

    const [dog, setDog] = useState({})

    useEffect(() => {
          const requestOptions = {
            method: 'GET',
            headers: {
              'Accept' : 'application/json',
            }
          }
              fetch(`https://localhost:7049/breeds/${id}`, requestOptions)
                .then(response => response.json())
                .then(newData => {
                  console.log(newData)
                  setDog(newData)
                })
          }, [])

    return (
        <Layout style={{height: '100%', padding: 10 }}>
          <Sider width={'35%'} style={{backgroundColor: 'transparent', fontSize: 25}}>
            <img alt={dog.name} src={dog.imageUrl} width={'100%'} />
            <p style={{textAlign: 'center', fontWeight: 'bold'}}>{dog.name}</p>
          </Sider>
          <Content style={{padding: 15, fontSize: 15}}>
            <DoubleMetricProperty header='Вес:' property={dog.weight}/>
            <DoubleMetricProperty header='Размеры:' property={dog.height}/>
            <h4 style={{display: 'inline'}}>Время жизни:</h4> {<Interval interval={dog.lifeSpan} />} лет
          </Content>
        </Layout>
    )
}

export default DogInfoPage