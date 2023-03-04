import { useEffect, useState } from "react";
import { Col, Row, Pagination, Layout, Collapse, Button } from 'antd';

import DogCard from '../components/DogCard';
import Sider from "antd/es/layout/Sider";

import '../styles/layout.css'
import Filter from "../components/Filter";

const { Header, Content, Footer } = Layout;
const { Panel } = Collapse;

function ParseFilter(filtersObject){
  return Object.keys(filtersObject).map(x => 
    [filtersObject[x].from !== undefined && `${x}=${filtersObject[x].from}-${filtersObject[x].to}`,
      filtersObject[x].enumValue && `${x}Type=${filtersObject[x].enumValue}`]
  ).flat(1).filter(x => x).join("&");
}

const MainPage = () => {
  const [pageSize, setPageSize] = useState(16);
  const [breeds, setBreeds] = useState([]);
  const [paginationCount, setPaginationCount] = useState(0);
  const [page, setPage] = useState(0);

  const [filters, setFilters] = useState({})
  const [saveFilters, setSaveFilters] = useState(false)

  const filtersInfo = [
    {
      key: 'lifeSpan',
      header: 'Время жизни',
      range: {
        min: 6,
        max: 20
      }
    },
    {
      key: 'weight',
      header: 'Вес',
      range: {
        min: 1,
        max: 200
      },
      enumValues: ['Imperial', 'Metric']
    },
    {
      key: 'height',
      header: 'Размеры',
      range: {
        min: 6,
        max: 89
      },
      enumValues: ['Imperial', 'Metric']
    }
  ]

  useEffect(() => {
    const requestOptions = {
      method: 'GET',
      headers: {
        'Accept' : 'application/json'
      }
    }
    
    const parsedFilters = ParseFilter(filters);

      // fetch(`https://api.thedogapi.com/v1/breeds?limit=${pageSize}&page=${page}`, requestOptions)
      fetch(`https://localhost:7049/breeds?limit=${pageSize}&page=${page}${parsedFilters && `&${parsedFilters}`}`, requestOptions)
        .then(response => {
          setPaginationCount(response.headers.get('pagination-count'))
          return response.json()
        })
        .then(newData => newData.length !== 0 || page === 0 ? setBreeds(newData) : setPage(0))
  }, [page, pageSize, filters])


  const collectFilters = () => {
    setSaveFilters(true)
  }

  const updateFilter = (key) => 
    (value) =>{
      setFilters(prevState => ({...prevState, [key]: value}))
    }

  return (
    <Layout className="transparent" style={{height: '100%'}}>
      <Header className="transparent">

      </Header>
      <Layout className="transparent">
        <Sider className="transparent" style={{ marginRight: 16 }}>
          <Collapse  style={{borderRadius: 8, backgroundColor: 'white'}}>
            {filtersInfo.map(filter => 
              <Panel key={filter.key} header={filter.header}>
                <Filter filter={filter} 
                  saveFiltersState={[saveFilters, setSaveFilters]} filters={updateFilter(filter.key)}/>
              </Panel>)}
          </Collapse>
          <Button type="default" style={{width: "100%", justifyContent: "center"}} onClick={collectFilters}>Применить фильтры</Button>
        </Sider>
        <Layout className="transparent">
          <Content className="transparent">
            <Row gutter={[16, 16]} key="mainRow">
              {breeds.map((dog) => 
                <Col key={dog.id}>
                  <DogCard dog={dog}/>
                </Col>)}
            </Row>
          </Content>
          <Footer className="transparent">
            <Pagination key="pagination"
              defaultCurrent={page} total={paginationCount} 
              pageSize={pageSize}
              style={{marginTop: 5}}
              onChange={(page, pageSize) => {
                setPage(page - 1)
                setPageSize(pageSize)
              }}/>
          </Footer>
        </Layout>
      </Layout>
    </Layout>
  );
}

export default MainPage