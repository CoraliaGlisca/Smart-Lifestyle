from flask import Flask, request, jsonify, render_template
import numpy as np
import pickle as p

app = Flask(__name__)
model = p.load(open('C:/Users/Cora/source/repos/SmartLifestyle/models/final_prediction.pickle','rb'))

@app.route("/index")                        
def index():
     return render_template('index.html')

@app.route('/submit', methods=['GET'])
def predictor():   
    cardio = request.args.get('Cardio', default = 0)
    weight = request.args.get('Weight', default = 0)
    plyo = request.args.get('Plyo', default = 0)
    laps = request.args.get('Laps', default = 0)
    machine = request.args.get('Machine', default = 0)
    band = request.args.get('Band', default = 0)
    bar = request.args.get('Bar', default = 0)
    bodyWeight = request.args.get('Body Weight', default = 0)
    bosuBall = request.args.get('BosuBalll', default = 0)
    dumbbells = request.args.get('Dumbbells', default = 0)
    kettlebells = request.args.get('Kettlebells', default = 0)
    landmine = request.args.get('Landmine', default = 0)
    platform = request.args.get('Platform', default = 0)
    squatRack = request.args.get('Squat Rack', default = 0)
    cable = request.args.get('Cable', default = 0)
    medicineBall = request.args.get('Medicine Ball', default = 0)
    arms = request.args.get('Arms', default = 0)
    back = request.args.get('Back', default = 0)
    core = request.args.get('Core', default = 0)
    fullBody = request.args.get('Full Body', default = 0)
    legs = request.args.get('Legs', default = 0)   

    features=list()
    features.append((cardio))
    features.append((weight))
    features.append((plyo))
    features.append((laps))
    features.append((machine))
    features.append((band))
    features.append((bar))
    features.append((bodyWeight))
    features.append((bosuBall))
    features.append((dumbbells))
    features.append((kettlebells))
    features.append((landmine))
    features.append((platform))
    features.append((squatRack))
    features.append((cable))
    features.append((medicineBall))
    features.append((arms))
    features.append((back))
    features.append((core))
    features.append((fullBody))
    features.append((legs))
    
    prediction=model.predict([np.array(features)])
    prediction = prediction[0].tolist()       
    return jsonify(prediction)
    

if __name__ == '__main__':
    
    app.run(debug=True, host='0.0.0.0')