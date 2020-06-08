from tensorflow.keras import Sequential
from tensorflow.keras.layers import Dense

# Dense and Sequential import
model = Sequential()

# add 은닉층과 출력층 추가
model.add(Dense(100, activation='relu', input_shape=(784,))
model.add(Dense(10, activation='softmax') # last output layer

# 최적화
model.compile(optimizer='sgd', loss='categorical_crossentropy', metrics=['accuracy'])

# training
History = model.fit(x_train, y_train_encoded, epochs=40, validation_data=(x_val, y_val_encoded))

# 손실과 정확도 그래프 그리기
print( History.history.keys())
# result = loss, accuracy, val_loss, val_accuracy
