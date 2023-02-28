import './App.css';
import { Route, BrowserRouter as Router, Routes, Link } from 'react-router-dom';
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
      <Router>
        <Layout style={layoutStyle}>
          <Header style={headerStyle}>
            <Link to='/' style={{fontWeight: 'bold', fontSize: 30, color: 'white'}}>TheDogApi</Link>
          </Header>
          <Content style={contentStyle}>
            <Routes>
              <Route path='/' element={<MainPage/>}/>
              <Route path='/:id' element={<DogInfoPage/>}/>
            </Routes>
          </Content>
        </Layout>
      </Router>
    </>
  );
}

export default App;
