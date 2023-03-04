import './App.css';
import { Route, BrowserRouter as Router, Routes, Link } from 'react-router-dom';
import { Layout } from 'antd';
import DogInfoPage from './containers/DogInfoPage';
import MainPage from './containers/MainPage';
import FeedbackPage from './containers/FeedbackPage';
import { Footer } from 'antd/es/layout/layout';

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
  backgroundColor: 'lightgray',
  padding: 10,
  margin: '10px 150px 50px'
};
const layoutStyle = {
  height: '100%',
  backgroundImage: 'url(bg.jpg)',
  backgroundSize: 'cover',
  backgroundAttachment: 'fixed',
};
const footerStyle = {
  backgroundColor: 'lightgray',
  display: 'grid',
  gridTemplateColumns: "repeat(1, 1fr)",
  gap: 10
};
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
              <Route path='/feedback' element={<FeedbackPage/>}/>
            </Routes>
          </Content>
          <Footer style={footerStyle}>
            <Link to="/feedback" style={{display:'flex', justifyContent: 'center'}}>Оставить отзыв</Link>
          </Footer>
        </Layout>
      </Router>
    </>
  );
}

export default App;
