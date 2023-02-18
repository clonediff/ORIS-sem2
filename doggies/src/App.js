import './App.css';
import { Route, BrowserRouter as Router, Routes } from 'react-router-dom';
import { Layout } from 'antd';
import DogInfoPage from './containers/DogInfoPage';
import MainPage from './containers/MainPage';

const { Header, Content } = Layout;
const headerStyle = {
  textAlign: 'center',
  color: '#fff',
  height: 64,
  paddingInline: 50,
  lineHeight: '64px',
  backgroundColor: '#7dbcea',
};
const contentStyle = {
  minHeight: 120,
  backgroundColor: 'lightgray',
  padding: 10,
  margin: '10px 150px 50px'
};
const layoutStyle = {
  height: '100%',
  backgroundImage: 'url(bg.jpg)',
  backgroundSize: 'cover',
  backgroundAttachment: 'fixed',
}
function App() {
  return (
    <>
      <Layout style={layoutStyle}>
        <Header style={headerStyle}>
          <span style={{fontWeight: 'bold', fontSize: 30}}>TheDogApi</span>
        </Header>
        <Content style={contentStyle}>
          <Router>
            <Routes>
              <Route path='/' element={<MainPage/>}/>
              <Route path='/:id' element={<DogInfoPage/>}/>
            </Routes>
          </Router>
        </Content>
      </Layout>
    </>
  );
}

export default App;
