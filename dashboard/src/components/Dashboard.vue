<template>
  <div>
    <div class="cards">
      <div class="card df jc-sb">
        <div class="card-text">
          <h4 class="card-title">Todays Money</h4>
          <div class="card-info df jc-sb">
            <h3>$53,000</h3>
            <h5>+55%</h5>
          </div>
        </div>
        <div class="card-img">
          <img src="../assets/money.svg" alt="money">
        </div>
      </div>
      <div class="card df jc-sb">
        <div class="card-text">
          <h4 class="card-title">Today’s Users</h4>
          <div class="card-info df jc-sb">
            <h3>2,300</h3>
            <h5>+5%</h5>
          </div>
        </div>
        <div class="card-img">
          <img src="../assets/mir.svg" alt="world">
        </div>
      </div>
      <div class="card df jc-sb">
        <div class="card-text">
          <h4 class="card-title">New Clients</h4>
          <div class="card-info df jc-sb">
            <h3>+3,052</h3>
            <h5 style="color: #EA0606">-14%</h5>
          </div>
        </div>
        <div class="card-img">
          <img src="../assets/doc.svg" alt="paper-diploma">
        </div>
      </div>
      <div class="card df jc-sb">
        <div class="card-text">
          <h4 class="card-title">Sales</h4>
          <div class="card-info df jc-sb">
            <h3>$173,000</h3>
            <h5>+8%</h5>
          </div>
        </div>
        <div class="card-img">
          <img src="../assets/shop.svg" alt="money">
        </div>
      </div>
    </div>
    <div class="Banners">
      <div class="df jc-sb bg40">
        <div class="banner2">
          <h4 style="font-size: 16px">Welcome back,</h4>
          <h3 style="font-size: 28px; color: white">Mark Johnson.</h3>
          <h4 style="font-size: 16px">Glad to see you again!<br> Ask me anything.</h4>
          <div class="TapToRecord df" style="color: white">
            <p>Tap to record</p>
            <img src="../assets/arrow-right.svg" alt="Path">
          </div>
        </div>
      </div>
      <div class="banner bg25">
        <div class="banner-text">
          <p style="color: white">Satisfaction Rate</p>
          <p>From all projects</p>
        </div>
        <div class="banner-img">
          <img src="../assets/content.png" alt="content">
        </div>
      </div>
      <div class="banner bg35" style="color: white">
        <div class="df jc-sb">
          <p>Referral Tracking</p>
          <img src="../assets/More.svg" alt="more">
        </div>
        <div class="tracking">
          <div class="order1">
            <div class="card card-setting">
              <p class="card-title">Invited</p>
              <p style="margin: 0; white-space:nowrap">145 people</p>
            </div>
            <div class="card card-setting">
              <p class="card-title">Bonus</p>
              <p style="margin: 0">1,465</p>
            </div>
          </div>
          <div class="order2">
            <img src="../assets/Safety.png" alt="Safety" class="Safety">
          </div>
        </div>
      </div>
    </div>
    <div class="Statistick">
      <div class="banner bg60">
        <div class="title">
          <p style="color: white">Sales Overview</p>
          <div class="df" style="margin: 10px 0 60px 0">
            <img src="../assets/morein2021.svg" alt="morein2021">
          </div>
        </div>
        <img src="../assets/graf.png" alt="graf" class="graf">
      </div>
      <div class="banner bg40 stat-banner" style="color: white">
        <img src="../assets/Chart.png" alt="chart" class="stat-img">
        <p>Active Users</p>
        <img src="../assets/thanlastweek.svg" alt="thanlastweek" style="margin-bottom: 30px">
        <div class="statisticInfo">
          <div class="stat">
            <div class="stat-tittle df">
              <div class="card-img2">
                <img src="../assets/banner-money.svg" alt="money">
              </div>
              <h6>Users</h6>
            </div>
            <div class="stat-body">
              <h3>32,984</h3>
              <img src="../assets/Progress.svg" alt="Progress">
            </div>
          </div>
          <div class="stat">
            <div class="stat-tittle df">
              <div class="card-img2">
                <img src="../assets/banner-sharp.svg" alt="sharp">
              </div>
              <h6>Clicks</h6>
            </div>
            <div class="stat-body">
              <h3>2,42m</h3>
              <img src="../assets/Progress2.png" alt="Progress">
            </div>
          </div>
          <div class="stat">
            <div class="stat-tittle df">
              <div class="card-img2">
                <img src="../assets/banner-shop.svg" alt="shop">
              </div>
              <h6>Sales</h6>
            </div>
            <div class="stat-body">
              <h3>2,400$</h3>
              <img src="../assets/Progress3.png" alt="Progress">
            </div>
          </div>
          <div class="stat">
            <div class="stat-tittle df">
              <div class="card-img2">
                <img src="../assets/banner-setting.svg" alt="setting">
              </div>
              <h6>Items</h6>
            </div>
            <div class="stat-body">
              <h3>320</h3>
              <img src="../assets/Progress.svg" alt="Progress">
            </div>
          </div>
        </div>
      </div>
    </div>
  </div>
</template>

<script lang='ts'>
import {defineComponent} from "vue";

export default defineComponent({
  name: 'Dashboard',
});
</script>

<style scoped>
  .df{
    display: flex;
  }
  .jc-sb{
    justify-content: space-between;
  }
  .cards{
    width: 98%;
    display: grid;
    grid-template-columns: repeat(4, 24%);
    gap: 0 14px;
  }
  .card{
    background: linear-gradient(126.97deg, rgba(6, 11, 38, 0.74) 28.26%,
    rgba(26, 31, 55, 0.5) 91.2%);
    backdrop-filter: blur(120px);
    border-radius: 16px;
    padding: 16px;
  }
  .card-title{
    margin-top: 0;
    font-size: 14px;
    color: #A0AEC0;
  }
  .card-info h3{
    font-size: 20px;
    color: white;
    margin: 0;
  }
  .card-info h5{
    font-size: 14px;
    color: #82D616;
    margin: 6px 0 0 4px;
  }
  .card-text h4{
    margin: 0 0 6px;
  }
  .card-img{
    width: 45px;
    height: 45px;
    background: #0075FF;
    box-shadow: 0 3.5px 5.5px rgba(0, 0, 0, 0.02);
    border-radius: 12px;
    text-align: center;
  }
  .card-img img{
    margin-top: 25%;
  }
  .card-setting{
    padding-right: 80px;
    margin-left: 10px;
    margin-top: 20px;
  }

  .Banners{
    display: flex;
    justify-content: space-between;
    margin: 24px 0;
    max-width: 98%;
  }
  .banner2{
    position:relative;
    color: #A0AEC0;
    background-size: 100% 100%;
    background: url(../assets/background.png) no-repeat;
    padding-left: 10px;
    width: 100%;
    padding: 20px;
    height: 300px;
  }
  .banner{
    padding: 20px;
    box-shadow: 0 20px 27px rgba(0, 0, 0, 0.05);
    background: linear-gradient(126.97deg, rgba(6, 11, 40, 0.74) 28.26%,
    rgba(14, 21, 58, 0.71) 91.2%);
    backdrop-filter: blur(120px);
    border-radius: 20px;
  }
  .bg60{
    width: 53%;
  }
  .bg40{
    width: 40%;
  }
  .bg25{
    width: 24%;
  }
  .bg35{
    width: 28%;
  }
  .banner-text{
    position:relative;
    color: #A0AEC0;
  }
  .tracking{
    display: flex;
    justify-content: space-between;
  }
  .TapToRecord{
    position:absolute;
    bottom:0;
    align-items: center;
    font-size: 14px;
  }
  .TapToRecord img{
    margin-top: 2px;
    margin-left: 10px;
  }
  .banner-img{
    width: 100%;
    height: 100%;
    text-align: center;
  }
  .Safety{
    width: 100%;
    margin-left: 8%;
    margin-top: 16%;
  }

  .Statistick{
    width: 98%;
    display: flex;
    justify-content: space-between;
  }
  .statisticInfo{
    width: 98%;
    display: grid;
    grid-template-columns: repeat(4, 24%);
    gap: 0 14px;
  }
  .card-img2{
    width: 25px;
    height: 25px;
    background: #0075FF;
    box-shadow: 0 3.5px 5.5px rgba(0, 0, 0, 0.02);
    border-radius: 8px;
    text-align: center;
  }
  .card-img2 img{
    width: 12px;
    height: 12px;
    margin-top: 25%;
  }
  .stat-tittle h6{
    font-size: 14px;
    color: #A0AEC0;
    margin: 4px 0 0 10px;
  }
  .stat-body h3{
    font-size: 18px;
    color: #ffff;
    margin: 6px 0 0;
  }
  .stat-img{
      width: 100%;
    }
  .graf{
    width: 100%;
  }
  @media (max-width: 420px){
    .cards{
      width: 110%;
      grid-template-columns: repeat(1, 90%);
      gap: 0 14px;
      margin-left: -14%;
    }
    .card
    {
      margin-bottom: 10px;
    }
    .Banners{
      display: block;
      margin-left: -14%;
    }
    .bg40{
      width: 100%;
    }
    .bg60{
      width: 88%;
    }
    .bg35{
      width: 88%;
    }
    .bg25{
      width: 88%;
    }
    .banner2{
      background-repeat: no-repeat;
      background: linear-gradient(126.97deg, rgba(6, 11, 40, 0.74) 28.26%, rgba(14, 21, 58, 0.71) 91.2%), url(../assets/background.png);
      border-radius: 20px;
      background-size: 100% 100%;
      margin-bottom: 20px;
    }
    .banner{
      margin-bottom: 20px;
    }
    .banner-img img{
      width: 80%;
      height: 80%;
    }
    .tracking{
      flex-flow: wrap;
      margin-left: 10%;
    }
    .order1{
      order: 2;
    }
    .order2{
      order: 1;
    }
    .Safety{
      width: 40%;
      margin: 0;
    }
    .Statistick{
      display: block;
      margin-left: -14%;
    }
    .statisticInfo{
      width: 98%;
      display: grid;
      grid-template-columns: repeat(2, 48%);
      gap: 0 10px;
      margin-left: 6%;
    }
    .statisticInfo :nth-child(1), :nth-child(2){
      margin-bottom: 2px;
    }
    .stat-body h3{
      margin: 0;
    }
    .stat-banner{
      height: 340px;
      margin-bottom: 10px;
      width: 88%;
    }
  }
</style>
