import { useEffect, useState } from "react";
import { Col, Row, Pagination } from 'antd';

import DogCard from '../components/DogCard';

const MainPage = () => {
  const pageSize = 21;
  const [breeds, setBreeds] = useState([]);
  const [paginationCount, setPaginationCount] = useState(0);
  const [page, setPage] = useState(0);
  const [fetching, setFetching] = useState(true)

  useEffect(() => {
    const requestOptions = {
      method: 'GET',
      headers: {
        'Content-Type' : 'application/json',
        'x-api-key': 'live_QnPWJXxM820UMS5YwZSNVpteTGnQOBymlEl6q3SVLfEv0VVJw2HGJpPCnCzEoB9W'
      }
    }

    if (fetching){
      fetch(`https://api.thedogapi.com/v1/breeds?limit=${pageSize}&page=${page}`, requestOptions)
        .then(response => {
          setPaginationCount(response.headers.get('pagination-count'))
          return response.json()
        })
        .then(newData => setBreeds(newData))
        .finally(() => setFetching(false))
    }
  }, [fetching])

  return (
    <>
      <Row gutter={[16, 16]} justify="space-around" key="mainRow">
        {breeds.map((dog) => 
          <Col key={dog.image && dog.image.id}>
            <DogCard dog={dog}/>
          </Col>)}
      </Row>
      <Pagination key="pagination"
        defaultCurrent={page} total={paginationCount} 
        pageSize={pageSize}
        showSizeChanger={false}
        style={{marginTop: 5}}
        onChange={(page, pageSize) => {
          setPage(page - 1)
          setFetching(true)
        }}/>
    </>
  );
}

export default MainPage